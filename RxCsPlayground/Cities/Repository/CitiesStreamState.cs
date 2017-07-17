using System.Collections.Generic;

namespace RxCsPlayground.Cities
{

    /// <summary>
    /// Imutabilná obálka interného stavu stránkovaného streamu miest a obcí
    /// </summary>
    internal class CitiesStreamState
    {        

        /// <summary>
        /// Aktuálne používaný filter
        /// </summary>
        public string Filter { get; }


        /// <summary>
        /// Aktuálna stránka
        /// </summary>
        public int Page { get; }


        /// <summary>
        /// Nájdený zoznam miest a obcí na aktuálnej stránke
        /// </summary>
        public IEnumerable<string> Cities { get; }


        #region Konštruktor


        public CitiesStreamState(string filter, int page, IEnumerable<string> cities)
        {
            Filter = filter;
            Page = page;
            Cities = cities;
        } 


        #endregion

    }
}