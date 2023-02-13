namespace Google_Apps_Viewer.GoogleApps
{
    public class GoogleApp
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public float Rating { get; set; }
        public int Reviews { get; set; }
        public string Size { get; set; }
        public string Installs { get; set; }
        public Type Type { get; set; }
        public string Price { get; set; }
        public string ContentRating { get; set; }
        public List<string> Genres { get; set; }
        public DateTime LastUpdated { get; set; }
        public string CurrentVer { get; set; }
        public string AndroidVer { get; set; }
    }
}
