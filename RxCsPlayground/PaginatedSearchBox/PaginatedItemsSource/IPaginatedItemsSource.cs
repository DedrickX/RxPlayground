using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxCsPlayground.PaginatedSearchBox
{
    public interface IPaginatedItemsSource
    {

        IObservable<PaginatedSearchResult> GetItems(string searchTerm);

    }
}
