using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxCsPlayground
{
    public class SearchResult
    {
        public string SearchTerm { get; private set; }

        public IEnumerable<string> Items { get; private set; }

        public SearchResult(string searchTerm, IEnumerable<string> items)
        {
            SearchTerm = searchTerm;
            Items = items;
        }
    }
}
