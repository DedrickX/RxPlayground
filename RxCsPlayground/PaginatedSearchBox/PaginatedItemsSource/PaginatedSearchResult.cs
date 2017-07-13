using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxCsPlayground.PaginatedSearchBox
{

    public abstract class PaginatedSearchResult
    {
    }


    public class SearchResult_StartingNewStream : PaginatedSearchResult
    {
        public string SearchTerm { get; private set; }

        public SearchResult_StartingNewStream(string searchTerm)
        {
            SearchTerm = searchTerm;
        }
    }


    public class SearchResult_ReturningItems : PaginatedSearchResult
    { 
        public string SearchTerm { get; private set; }

        public int PageNr { get; private set; }

        public IEnumerable<string> Items { get; private set; }

        public SearchResult_ReturningItems(string searchTerm, int pageNr, IEnumerable<string> items)
        {
            SearchTerm = searchTerm;
            PageNr = pageNr;
            Items = items;
        }

    }

}
