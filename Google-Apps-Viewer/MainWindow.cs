using CsvHelper;
using System.Globalization;
using Google_Apps_Viewer.GoogleApps;

namespace Google_Apps_Viewer
{
    public partial class MainWindow : Form
    {
        List<GoogleApp> googleApps;
        public MainWindow()
        {
            InitializeComponent();

            var currentDir = Directory.GetCurrentDirectory();
            var csvPath = Path.GetRelativePath(currentDir, "GoogleApps/googleplaystore.csv");
            googleApps = LoadGoogleAps(csvPath);

            int i = 0;
            foreach(var app in googleApps)
            {
                dataGridView.Rows.Add(googleApps[i].Name, googleApps[i].Category, 
                    googleApps[i].Rating, googleApps[i].Reviews, googleApps[i].Size,
                    googleApps[i].Type);
                i++;
                if (i > 100) break;
            }
            
        }

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

        
    }
}