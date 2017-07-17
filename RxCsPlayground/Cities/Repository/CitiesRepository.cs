using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxCsPlayground.Cities
{

    /// <summary>
    /// Repository poskytujúce zoznam miest a obcí
    /// </summary>
    public class CitiesRepository : ICitiesRepository
    {

        /// <summary>
        /// Interná "akože databáza" miest a obcí :)
        /// </summary>
        private List<string> _cities;


        /// <summary>
        /// Počet položiek, ktoré prídu v jednej "stránke" výsledkov vyhľadávania
        /// </summary>
        public const int ItemsPerPage = 5;


        /// <summary>
        /// Umelé oneskorenie simulujúce zložité načítavanie dát zo zdroja
        /// </summary>
        public int FakeLoadDelay = 200;


        #region Konštruktor


        public CitiesRepository(List<string> cities)
        {
            _cities = cities;
        } 


        #endregion
               


        /// <summary>
        /// Funkcia vráti zoznam miest a obcí obsahujúcich v názve daný reťazec. Výsledok je vo forme streamu kolekcií - akože stránok.
        /// </summary>
        /// <remarks>
        /// Využijeme korekurziu - funkcii Observable.Generate podhodíme pár ďalších funkcií na základe ktorých bude generovať stream.
        /// </remarks>
        public IObservable<CitiesStreamItem> GetCities(string filter) =>            
            Observable.Generate(
                FindCitiesAndCreateNewState(filter, 0),
                x => x.Cities.Count() > 0,
                x => FindCitiesAndCreateNewState(x.Filter, x.Page + 1),
                x => new CitiesStreamItem(x.Page, x.Cities));
                                

        /// <summary>
        /// Funkcia vracajúca filtrovaciu funkciu podľa filtrovaného reťazca
        /// </summary>        
        private Func<string, bool> GetFilterPredicate(string filter) =>
            x => x.ToLower().Contains(filter.ToLower());


        /// <summary>
        /// Funkcia vyhľadá mestá a obce podľa filtra patriace danej stránke a vráti ich vo forme nového interného stavu
        /// </summary>        
        private CitiesStreamState FindCitiesAndCreateNewState(string filter, int page) =>        
            new CitiesStreamState(filter, page, _cities
                .Where(GetFilterPredicate(filter))
                .Skip(page * ItemsPerPage)
                .Take(ItemsPerPage));
                                        
    }

}
