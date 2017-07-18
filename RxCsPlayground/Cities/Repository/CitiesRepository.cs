using RxCsPlayground.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RxCsPlayground.Cities
{

    /// <summary>
    /// Repository poskytujúce zoznam miest a obcí
    /// </summary>
    public class CitiesRepository : ICitiesRepository
    {                

        /// <summary>
        /// Počet položiek, ktoré prídu v jednej "stránke" výsledkov vyhľadávania
        /// </summary>
        public const int ItemsPerPage = 5;


        /// <summary>
        /// Maximálny počet stránok, ktoré vrátime
        /// </summary>
        public const int MaxPagesCount = 20;


        /// <summary>
        /// Umelé oneskorenie pri načítaní stránky údajov - akože to ide z databázy alebo webového servisu
        /// </summary>
        public const int LoadItemsDelay = 200;


        /// <summary>
        /// Generátor náhodných čísel pre náhodné chyby...
        /// </summary>
        private Random _randomizer;


        /// <summary>
        /// Interná "akože databáza" miest a obcí :)
        /// </summary>
        private List<string> _cities;


        #region Konštruktor


        public CitiesRepository()
        {
            _cities = Resources.CitiesList
                .Split(';')
                .ToList();

            _randomizer = new Random();
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
                currentState => (currentState.Page == 0) || // vždy schválne vrátim prvú stránku, aj keď je prázdna. Pri page 0 totiž čistím ListBox... :D
                                ((currentState.Page < MaxPagesCount) && (currentState.Cities.Count() > 0)),
                currentState => FindCitiesAndCreateNewState(currentState.Filter, currentState.Page + 1),
                currentState => new CitiesStreamItem(currentState.Page, currentState.Cities));


        /// <summary>
        /// Funkcia vracajúca filtrovaciu funkciu podľa filtrovaného reťazca
        /// </summary>
        private Func<string, bool> GetFilterPredicate(string filter) =>
            x => string.IsNullOrWhiteSpace(filter)
                ? true
                : x.ToLower().Contains(filter.ToLower());


        /// <summary>
        /// Funkcia vyhľadá mestá a obce podľa filtra patriace danej stránke a vráti ich vo forme nového interného stavu
        /// </summary>
        private CitiesStreamState FindCitiesAndCreateNewState(string filter, int page)
        {
            Debug.Print($"Repository - stránka {page}, výraz \"{filter}\", ThreadId: {Thread.CurrentThread.ManagedThreadId}");

            // simulujeme pomalé načítavanie údajov
            Thread.Sleep(LoadItemsDelay);

            // ak chceš vidieť čo sa stane pri náhodnej chybe, toto odkomentuj
            //if (_randomizer.Next(20) ==  0)
            //    throw new Exception("Len tak pre srandu :)");            

            // vrátime výsledok - nový state objekt
            return new CitiesStreamState(filter, page, _cities
                .Where(GetFilterPredicate(filter))
                .Skip(page* ItemsPerPage)
                .Take(ItemsPerPage));
        }

    }

}
