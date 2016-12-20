using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUiExample
{
    public class MainViewModel : ReactiveObject
    {  
                        
        /// <summary>
        /// Konštruktor ViewModelu
        /// </summary>
        public MainViewModel()
        {
            this.WhenAnyValue(x => x.Meno, x => x.Priezvisko)     // akonáhle sa zmení niektorá z týchto hodnôt
               .Select(x => x.Item1 + " " + x.Item2)              // reťazce spoj s medzerou medzi nimi
               .ToProperty(this, x => x.CeleMeno, out _CeleMeno); // a výsledok daj do Observable _CeleMeno a verejnej property CeleMeno
        }


        #region Property ViewModelu
        
        private string _Meno;
        public string Meno
        {
            get { return _Meno; }
            set { this.RaiseAndSetIfChanged(ref _Meno, value); }
        }


        private string _Priezvisko;
        public string Priezvisko
        {
            get { return _Priezvisko; }
            set { this.RaiseAndSetIfChanged(ref _Priezvisko, value); }
        }


        readonly ObservableAsPropertyHelper<string> _CeleMeno;
        public string CeleMeno
        {
            get { return _CeleMeno.Value; }
        }


        #endregion

    }
}
