using CsvHelper;
using System.Globalization;
using Google_Apps_Viewer.GoogleApps;

namespace Google_Apps_Viewer
{
    public partial class MainWindow : Form
    {
        #region list of variables
        private List<GoogleApp> googleApps;
        public static Dictionary<string, bool> IsFilterActive;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            InitializeActiveFilters();
            //adding categories to comboBox
            categoryComboBox.Items.Add("");
            categoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
            //creating GoogleApp object from csv file
            var currentDir = Directory.GetCurrentDirectory();
            var csvPath = Path.GetRelativePath(currentDir, "GoogleApps/googleplaystore.csv");
            googleApps = LoadGoogleAps(csvPath);
        }

        public static void InitializeActiveFilters()
        {
            IsFilterActive = new Dictionary<string, bool>()
            {
                {"category", false },
                {"nameContains",false }
            };
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
        }

        private List<GoogleApp> filterAppsByCategory()
        {
            if (categoryComboBox.SelectedItem != null && categoryComboBox.SelectedIndex != 0)
            {
                var selectedCategory = categoryComboBox.SelectedItem.ToString();
                IsFilterActive["category"] = true;
                return googleApps.Where(a => a.Category.ToString() == selectedCategory).ToList();
            }
            IsFilterActive["category"] = false;
            return new List<GoogleApp>();
        }
        private List<GoogleApp> filterByNameContains(string pattern)
        {
            if(pattern.Trim() != null && pattern != "")
            {
                IsFilterActive["nameContains"] = true;
                return googleApps.Where(a => a.Name.Contains(pattern)).ToList();
            }
            IsFilterActive["nameContains"] = false;
            return new List<GoogleApp>();       
        }

        private void applyFilters_OnClick(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            List<GoogleApp> result = googleApps;

            var categories = filterAppsByCategory();    
            var names = filterByNameContains(textBoxName.Text);

            if (IsFilterActive["category"])
                result = categories.Intersect(result).ToList();
            if (IsFilterActive["nameContains"])
                result = names.Intersect(result).ToList();

            if(result.Count > 1000)
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