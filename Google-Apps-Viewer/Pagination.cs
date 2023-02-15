using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Apps_Viewer
{
    internal class Pagination<T>
    {
        public Pagination(List<T> results, int resultsOnPage) 
        {
            SetPagination(results, resultsOnPage);
        }
        public Pagination()
        {

        }
        public List<T> Results { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public int TotalPages { get; set; }
        public int ResultsOnPage { get; set; }
        public int CurrentPage { get; set; }

        /// <summary>
        /// Initalize pagination with given lists
        /// </summary>
        /// <param name="results">List of elements to paginate</param>
        /// <param name="resultsOnPage">How many results should be shown per page</param>
        public void SetPagination(List<T> results, int resultsOnPage)
        {
            Results = results;
            ResultsOnPage = resultsOnPage;
            TotalPages = (results.Count % resultsOnPage == 0)
                ? results.Count / resultsOnPage : results.Count / resultsOnPage + 1;
        }
        /// <summary>
        /// Return results on page, given as a parameter. 
        /// Set From and To property properly (counting from 0)
        /// </summary>
        /// <param name="pageNumber">page number (from 1 to TotalPage)
        /// return null if pageNumber is out of range</param>
        /// <returns></returns>
        public List<T> CurrentPageResults(int pageNumber)
        {
            if (pageNumber > TotalPages || pageNumber < 1)
                return null;

            List<T> paginatedResults = new List<T>();
            CurrentPage = pageNumber;
            From = (pageNumber - 1) * ResultsOnPage;
            To = (pageNumber == TotalPages) ? Results.Count : From + ResultsOnPage;

            for (int i = From; i < To; i++)
            {
                paginatedResults.Add(Results[i]);
            }
            return paginatedResults;
        }

        /// <summary>
        /// Return true if results have to be paginated (Results count is bigger than ResultsOnPage)
        /// </summary>
        /// <returns></returns>
        public bool IsPaginated()
        {
            return TotalPages > 1;
        }

    }
}
