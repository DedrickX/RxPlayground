﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading.Tasks;

namespace RxCsPlayground.Cities
{

    /// <summary>
    /// Interface pre repository poskytujúce zoznam miest a obcí
    /// </summary>
    public interface ICitiesRepository
    {

        /// <summary>
        /// Funkcia vráti zoznam miest a obcí obsahujúcich v názve daný reťazec. Výsledok je vo forme streamu kolekcií - akože stránok.
        /// </summary>
        /// <param name="itemsPerPage">Počet položiek vrátených v jednej stránke</param>
        /// <param name="maxPagesCount">Maximálny počet vrátených stránok s údajmi</param>
        IObservable<CitiesStreamItem> GetCities(string filter, int itemsPerPage, int maxPagesCount);
        
    }
    
}
