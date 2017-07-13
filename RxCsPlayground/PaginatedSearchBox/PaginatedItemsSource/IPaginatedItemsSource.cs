using System;

namespace RxCsPlayground.PaginatedSearchBox
{
    /// <summary>
    /// Interface pre asynchrónny zdroj dát podporujúci stránkovanie
    /// </summary>
    public interface IPaginatedItemsSource
    {

        /// <summary>
        /// Vyhľadanie položiek obsahujúcich vyhľadávaný výraz
        /// </summary>
        IObservable<PaginatedSearchResult> GetItems(string searchTerm);

    }
}
