using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxCsPlayground.Cities
{

    /// <summary>
    /// Obálka nastavení filtra
    /// </summary>
    public class CitiesStreamFilterSettings
    {

        /// <summary>
        /// Filtrovaný výraz
        /// </summary>
        public string SearchTerm { get; }


        /// <summary>
        /// Počet položiek na jednu stránku
        /// </summary>
        public int ItemsPerPage { get; }


        /// <summary>
        /// Maximálny počet vrátených stránok
        /// </summary>
        public int MaxPagesCount { get; }


        public CitiesStreamFilterSettings(string searchTerm, int itemsPerPage, int maxPagesCount)
        {
            SearchTerm = searchTerm;
            ItemsPerPage = itemsPerPage;
            MaxPagesCount = maxPagesCount;
        }

    }

}
