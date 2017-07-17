using System;
using System.Collections.Generic;
using System.Linq;
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
        IObservable<CitiesStreamItem> GetCities(string filter);
        
    }
    
}
