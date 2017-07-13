using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxCsPlayground.PaginatedSearchBox
{

    /// <summary>
    /// Obálka údajov predstavujúcich stav vyhľadávania a stránkovania
    /// </summary>
    /// <remarks>
    /// Jedná sa o imutabilný objekt v duchu funkcionálneho prístupu...
    /// </remarks>
    class PaginatedSearchState
    {

        /// <summary>
        /// Vyhľadávaný výraz
        /// </summary>
        public string SearchTerm { get; private set; }


        /// <summary>
        /// Aktuálne spracovávaná stránka údajov
        /// </summary>
        public int PageNr { get; private set; }


        /// <summary>
        /// Nájdené položky zodpovedajúce vyhľadávanému výrazu patriace do danej stránky
        /// </summary>
        public IEnumerable<string> Items { get; set; }


        /// <summary>
        /// Aktuálny stav vyhľadávania
        /// </summary>
        public StateVariant State { get; private set; }


        #region Ctor a inits


        /// <summary>
        /// Nový state objekt s default hodnotami
        /// </summary>
        /// <param name="searchTerm"></param>
        public PaginatedSearchState(string searchTerm)
        {
            SearchTerm = searchTerm;
            PageNr = 0;
            State = StateVariant.New;
            Items = Enumerable.Empty<string>();
        }


        /// <summary>
        /// Vytvorenie nového State objektu podľa aktuálneho
        /// </summary>
        public PaginatedSearchState ChangeState(int newPage, IEnumerable<string> items, StateVariant newState)
        {
            var ret = new PaginatedSearchState(SearchTerm);
            ret.PageNr = newPage;
            ret.Items = items;
            ret.State = newState;
            return ret;
        }


        #endregion

    }

    public enum StateVariant
    {

        /// <summary>
        /// Vyhľadávanie sa začalo
        /// </summary>
        New,

        /// <summary>
        /// Vraciame položky
        /// </summary>
        ReturningItems,

        /// <summary>
        /// Už nie sú žiadne
        /// </summary>
        Done

    }

}