using System.Collections.Generic;

namespace RxCsPlayground.Cities
{    

    /// <summary>
    /// Položka streamu miest a obcí nesúca jednu stránku zoznamu položiek
    /// </summary>
    public class CitiesStreamItem
    {

        /// <summary>
        /// Číslo stránky vyhľadaných údajov
        /// </summary>
        public int Page { get; }


        /// <summary>
        /// Nájdený zoznam miest a obcí danej stránky
        /// </summary>
        public IEnumerable<string> Cities { get; }


        #region Konštruktor


        public CitiesStreamItem(int page, IEnumerable<string> cities)
        {
            Page = page;
            Cities = cities;
        } 


        #endregion

    }

}
