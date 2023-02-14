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
        #endregion
        public MainWindow()
        {
            //creating GoogleApp object from csv file
            var currentDir = Directory.GetCurrentDirectory();
            var csvPath = Path.GetRelativePath(currentDir, "GoogleApps/googleplaystore.csv");
            googleApps = LoadGoogleAps(csvPath);
            
            InitializeComponent();
            InitializeCategoryComboBox();
            InitializeRatingComboBoxes();
        }

        public void InitializeCategoryComboBox()
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
        public void InitializeRatingComboBoxes()
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
        private void DisplayApp(GoogleApp app)
        {
            dataGridView.Rows.Add(
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
        private void DisplayApps(List<GoogleApp> apps, int count)
        {
            if(count == 0)
            {
                foreach (GoogleApp app in apps)
                {
                    DisplayApp(app);
                }
            }
            else
            {
                int i = 1;
                foreach (GoogleApp app in apps)
                {
                    DisplayApp(app);
                    i++;
                    if (i > count)
                        break;
                }
            }
            labelRecordsCount.Text = apps.Count.ToString();
        }

        private List<GoogleApp> filterAppsByCategory()
        {
            var result = googleApps;
            if (categoryComboBox.SelectedItem != null && categoryComboBox.SelectedIndex != 0)
            {
                var selectedCategory = (Category)(categoryComboBox.SelectedIndex - 1);
                
                return result
                    .Where(a => a.Category.ToString() == Enum.GetName(selectedCategory)).ToList();
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

        private void applyFilters_OnClick(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            List<GoogleApp> result = googleApps;

            var categories = 
                (categoryComboBox.SelectedItem != null) ? filterAppsByCategory(): null;    
            var names = 
                (textBoxName.Text.Length > 0) ? filterByNameContains(textBoxName.Text) : null;
            var ratingsFrom = 
                (comboBoxRatingFrom.SelectedItem != null) ? filterByRating("from") : null;
            var ratingsTo =
                (comboBoxRatingTo.SelectedItem != null) ? filterByRating("to") : null;

            if (categories != null)
                result = categories.Intersect(result).ToList();
            if (names != null)
                result = names.Intersect(result).ToList();
            if (ratingsFrom != null)
                result = ratingsFrom.Intersect(result).ToList();
            if (ratingsTo != null)
                result = ratingsTo.Intersect(result).ToList();

            if (result.Count > 1000)
            {
                MessageBox.Show("To many results. Showing first 1000.", "To many results",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayApps(result, 1000);
            }
            else
            {
                DisplayApps(result, 0);
            }
        }
    }
}