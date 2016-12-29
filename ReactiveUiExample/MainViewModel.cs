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
    /// <summary>
    /// ViewModel pre hlavný formulár
    /// </summary>
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

            this.WhenAnyValue(x => x.Number1, x => x.Number2)
                .Select(x => x.Item1 + x.Item2)
                .ToProperty(this, x => x.AdditionResult, out _AdditionResult);
        }


        #region Property ViewModelu
                

        public string Meno
        {
            get { return _Meno; }
            set { this.RaiseAndSetIfChanged(ref _Meno, value); }
        }
        private string _Meno;

                
        public string Priezvisko
        {
            get { return _Priezvisko; }
            set { this.RaiseAndSetIfChanged(ref _Priezvisko, value); }
        }
        private string _Priezvisko;


        public string CeleMeno
        {
            get { return _CeleMeno.Value; }
        }
        readonly ObservableAsPropertyHelper<string> _CeleMeno;


        public int Number1
        {
            get { return _Number1; }
            set { this.RaiseAndSetIfChanged(ref _Number1, value); }
        }
        private int _Number1;
        

        public int Number2
        {
            get { return _Number2; }
            set { this.RaiseAndSetIfChanged(ref _Number2, value); }
        }
        private int _Number2;
        

        public int AdditionResult
        {
            get { return _AdditionResult.Value; }
        }
        private readonly ObservableAsPropertyHelper<int> _AdditionResult;
                        

        #endregion

    }
}
