using CsvHelper;
using System.Globalization;
using Google_Apps_Viewer.GoogleApps;
using System.Text;

namespace Google_Apps_Viewer
{
    public partial class MainWindow : Form
    {
        #region list of variables
        private List<GoogleApp> googleApps;
        private List<GoogleApp> filteredApps;
        private List<GoogleApp> currentPage;
        private Pagination<GoogleApp> paginatedResults;
        #endregion
        public MainWindow()
        {
            //creating GoogleApp object from csv file
            var currentDir = Directory.GetCurrentDirectory();
            var csvPath = Path.GetRelativePath(currentDir, "GoogleApps/googleplaystore.csv");
            googleApps = LoadGoogleAps(csvPath);
            filteredApps = googleApps;
            paginatedResults = new Pagination<GoogleApp>();
            currentPage = new List<GoogleApp>();

            InitializeComponent();
            InitializeCategoryComboBox();
            InitializeComboBoxes();
            SetPaginationInterface();
            labelMinReviewsError.Visible = false;
            labelMaxReviewsError.Visible = false;

            MinimumSize= new Size(Size.Width, Size.Height);
            MaximumSize = new Size(Size.Width, Size.Height);
        }

        private void InitializeCategoryComboBox()
        {
            categoryComboBox.Items.Add("");
            var groupByCategory = googleApps.GroupBy(a => a.Category)
                .OrderBy(g => g.Key);//get alphabetical order as in Enum Category
            foreach(var group in groupByCategory)
            {
                var apps = group.ToList();
                categoryComboBox.Items.Add(Enum.GetName(group.Key) + " ("
                    + group.Count(g => true) + ")");
            }
        }
        private void InitializeComboBoxes()
        {
            comboBoxRatingFrom.Items.Add("");
            comboBoxRatingFrom.Items.Add("1");
            comboBoxRatingFrom.Items.Add("2");
            comboBoxRatingFrom.Items.Add("2,5");
            comboBoxRatingTo.Items.Add("");
            comboBoxRatingTo.Items.Add("1");
            comboBoxRatingTo.Items.Add("2");
            comboBoxRatingTo.Items.Add("2,5");
            for (float f=3F; f<=5; f += 0.1F)
            {
                comboBoxRatingFrom.Items.Add(Math.Round(f,2).ToString());
                comboBoxRatingTo.Items.Add(Math.Round(f, 2).ToString());
            }
            comboBoxType.Items.Add("");
            comboBoxType.Items.Add("Free");
            comboBoxType.Items.Add("Paid");
        }
        private void SetPaginationInterface()
        {
            buttonNextPage.Enabled = false;
            buttonPrevPage.Enabled = false;
            labelPageNumber.Text = "";
        }

        /// <summary>
        /// Convert csv file with google play store apps info, to list of GoogleApp type
        /// </summary>
        /// <param name="csvPath"></param>
        /// <returns></returns>
        static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }
        }
        /// <summary>
        /// Add one app to dataGridView
        /// </summary>
        /// <param name="app">One record from of GoogleApp type</param>
        private void DisplayApp(GoogleApp app, int index)
        {
            dataGridView.Rows.Add(
                index,
                app.Name, 
                app.Category,
                app.Rating,
                app.Reviews,
                app.Size,
                app.Type);
        }
        /// <summary>
        /// Display list of apps in dataGridView
        /// </summary>
        /// <param name="apps">list of GoogleApps</param>
        /// <param name="count">number indicated how many apps should be displayed, 
        /// if 0 whole list is will be displayed</param>
        private void DisplayApps(List<GoogleApp> apps, int from)
        {
            foreach (GoogleApp app in apps)
            {
                DisplayApp(app, from);
                from++;
            }
        }

        private List<GoogleApp> filterByComboBox(string type)
        {
            ComboBox comboBox;
            if (type == "category") comboBox = categoryComboBox;
            else comboBox = comboBoxType;

            var result = googleApps;
            if (comboBox.SelectedIndex != 0)
            {
                if (type == "category")
                {
                    var selectedProp = (Category)(comboBox.SelectedIndex - 1);
                    return result
                        .Where(a => a.Category.ToString() == Enum.GetName(selectedProp)).ToList();
                }
                else
                {
                    var selectedProp = (GoogleApps.Type)(comboBox.SelectedIndex - 1);
                    return result
                        .Where(a => a.Type.ToString() == Enum.GetName(selectedProp)).ToList();
                }
            }
            return result;
        }
        private List<GoogleApp> filterByNameContains(string pattern)
        {
            var result = googleApps;
            if(pattern.Trim() != null && pattern != "")
            {
                return result.Where(a => a.Name.Contains(pattern)).ToList();
            }
            return result;       
        }
        private List<GoogleApp> filterByRating(string fromto)
        {
            float ratingFrom = 0;
            float ratingTo = 0;
            List<GoogleApp> result = googleApps;
            if (fromto=="from" && float.TryParse(comboBoxRatingFrom.SelectedItem.ToString(), out ratingFrom))
            {
                result = result.Where(a => a.Rating >= ratingFrom).ToList();
            }
            if (fromto=="to" && float.TryParse(comboBoxRatingTo.SelectedItem.ToString(), out ratingTo))
            {
                result = result.Where(a => a.Rating <= ratingTo).ToList();
            }
            return result;
        }
        private List<GoogleApp> filterByReviews(string minmax)
        {
            int minReviews = -1;
            int maxReviews = -1;
            List<GoogleApp> result = googleApps;
            if(minmax == "min")
            {
                if (Int32.TryParse(textBoxMinReviews.Text, out minReviews))
                {
                    result = result.Where(a => a.Reviews >= minReviews).ToList();
                    labelMinReviewsError.Visible = false;
                }
                else
                {
                   labelMinReviewsError.Visible = true;
                }
            }
            if (minmax == "max")
            {
                if (Int32.TryParse(textBoxMaxReviews.Text, out maxReviews))
                {
                    result = result.Where(a => a.Reviews <= maxReviews).ToList();
                    labelMaxReviewsError.Visible = false;
                }
                else
                {
                    labelMaxReviewsError.Visible = true;
                }
            }
            return result;
        }

        private void applyFilters_OnClick(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            filteredApps = googleApps;

            var categories =
                (categoryComboBox.SelectedItem != null) ? filterByComboBox("category") : null;
            var names =
                (textBoxName.Text.Length > 0) ? filterByNameContains(textBoxName.Text) : null;
            var ratingsFrom =
                (comboBoxRatingFrom.SelectedItem != null) ? filterByRating("from") : null;
            var ratingsTo =
                (comboBoxRatingTo.SelectedItem != null) ? filterByRating("to") : null;
            var minReviews =
                (textBoxMinReviews.Text.Length > 0) ? filterByReviews("min") : null;
            var maxReviews =
                (textBoxMaxReviews.Text.Length > 0) ? filterByReviews("max") : null;
            var types =
                (comboBoxType.SelectedItem != null) ? filterByComboBox("type") : null;

            if (categories != null)
                filteredApps = categories.Intersect(filteredApps).ToList();
            if (names != null)
                filteredApps = names.Intersect(filteredApps).ToList();
            if (ratingsFrom != null)
                filteredApps = ratingsFrom.Intersect(filteredApps).ToList();
            if (ratingsTo != null)
                filteredApps = ratingsTo.Intersect(filteredApps).ToList();
            if (minReviews != null)
                filteredApps = minReviews.Intersect(filteredApps).ToList();
            else
                labelMinReviewsError.Visible = false;
            if (maxReviews != null)
                filteredApps = maxReviews.Intersect(filteredApps).ToList();
            else
                labelMaxReviewsError.Visible = false;
            if (types != null)
                filteredApps = types.Intersect(filteredApps).ToList();

            labelRecordsCount.Text = filteredApps.Count.ToString();
            paginatedResults.SetPagination(filteredApps, 15);
            bool isPaginated = paginatedResults.IsPaginated();
            if (!isPaginated)
            {
                DisplayApps(filteredApps, 1);
                labelPageNumber.Text = "Page: 1/1";
                buttonNextPage.Enabled = false;
                buttonPrevPage.Enabled = false;
            }
            else
            {
                currentPage = paginatedResults.CurrentPageResults(1);
                DisplayApps(currentPage, 1);
                buttonNextPage.Enabled = true;
                buttonPrevPage.Enabled = false;
                labelPageNumber.Text = $"Page: 1/{paginatedResults.TotalPages}";
            }
        }
        private void nextPageButton_OnClick(object sender, EventArgs e)
        {
            currentPage = paginatedResults.CurrentPageResults(paginatedResults.CurrentPage + 1);
            dataGridView.Rows.Clear();
            DisplayApps(currentPage, paginatedResults.From + 1);
            if(paginatedResults.CurrentPage == paginatedResults.TotalPages)
            {
                buttonNextPage.Enabled = false;
            }
            buttonPrevPage.Enabled = true;
            labelPageNumber.Text = $"Page: {paginatedResults.CurrentPage}/{paginatedResults.TotalPages}";
        }

        private void prevPageButton_OnClick(object sender, EventArgs e)
        {
            currentPage = paginatedResults.CurrentPageResults(paginatedResults.CurrentPage - 1);
            dataGridView.Rows.Clear();
            DisplayApps(currentPage, paginatedResults.From + 1);
            if (paginatedResults.CurrentPage == 1)
            {
                buttonPrevPage.Enabled = false;
            }
            buttonNextPage.Enabled = true;
            labelPageNumber.Text = $"Page: {paginatedResults.CurrentPage}/{paginatedResults.TotalPages}";
        }
    }
}