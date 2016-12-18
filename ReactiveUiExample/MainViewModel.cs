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

        #region Ctor a inicializácia
        
        public MainViewModel()
        {
            this.WhenAnyValue(x => x.Meno, x => x.Priezvisko)
               .Select(x => x.Item1 + " " + x.Item2)
               .ToProperty(this, x => x.CeleMeno, out _CeleMeno);            
        }

        #endregion


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

    }
}
