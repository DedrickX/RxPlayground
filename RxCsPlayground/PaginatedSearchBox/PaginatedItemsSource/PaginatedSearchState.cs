using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxCsPlayground.PaginatedSearchBox
{
    class PaginatedSearchState
    {
        public string SearchTerm { get; private set; }


        public int PageNr { get; private set; }


        public IEnumerable<string> Items { get; set; }


        public StateVariant State { get; private set; }


        public PaginatedSearchState(string searchTerm)
        {
            PageNr = 0;
            State =  StateVariant.New;
            Items = Enumerable.Empty<string>();
        }


        public PaginatedSearchState ChangeState(int newPage, IEnumerable<string> items, StateVariant newState)
        {
            var ret = new PaginatedSearchState(SearchTerm);
            ret.PageNr = newPage;
            ret.Items = items;
            ret.State = newState;
            return ret;
        }

    }

    public enum StateVariant
    {
        New,
        ReturningItems,
        Done
    }

}
