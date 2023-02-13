using CsvHelper.Configuration;
using CsvHelper;

namespace Google_Apps_Viewer.GoogleApps
{
    public sealed class GoogleAppMap : ClassMap<GoogleApp>
    {
        public GoogleAppMap()
        {
            Map(m => m.Name).Name(nameof(GoogleApp.Name));
            Map(m => m.Category).Name(nameof(GoogleApp.Category));
            Map(m => m.Rating).Name(nameof(GoogleApp.Rating));
            Map(m => m.Reviews).Name(nameof(GoogleApp.Reviews));
            Map(m => m.Size).Name(nameof(GoogleApp.Size));
            Map(m => m.Installs).Name(nameof(GoogleApp.Installs));
            Map(m => m.Type).Name(nameof(GoogleApp.Type));
            Map(m => m.Price).Name(nameof(GoogleApp.Price));
            Map(m => m.Name).Name(nameof(GoogleApp.Name));
            Map(m => m.ContentRating).Name(nameof(GoogleApp.ContentRating));
            Map(m => m.LastUpdated).Name(nameof(GoogleApp.LastUpdated));
            Map(m => m.Genres).Convert(ConvertGenres);
            Map(m => m.CurrentVer).Name(nameof(GoogleApp.CurrentVer));
            Map(m => m.AndroidVer).Name(nameof(GoogleApp.AndroidVer));
        }

        private List<string> ConvertGenres(ConvertFromStringArgs args)
        {
            var genreString = args.Row.GetField("Genres");
            return genreString.Split(";").ToList();
        }
    }
}
