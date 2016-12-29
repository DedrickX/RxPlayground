using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Windows.Forms;


namespace ReactiveUiExample
{
    /// <summary>
    /// Hlavný formulár
    /// </summary>
    public partial class MainView : Form, IViewFor<MainViewModel>
    {

        /// <summary>
        /// Konštruktor formulára
        /// </summary>
        public MainView()
        {
            InitializeComponent();

            // bindovanie komponentov formulára na ViewModel je vykonané vo funkcii zaregistrovanej cez WhenActivated
            this.WhenActivated(registerDisposable =>
            {
                // Každý Bind vráti disposable objekt, ktorým je možné binding zrušiť. Preto tieto disposable
                // objekty registrujeme do kolekcie na to určenej, ktorá po ukončení práce s formulárom všetko
                // uvoľní.
                registerDisposable(this.Bind(ViewModel, 
                                             x => x.Meno, 
                                             x => x.TxtMeno.Text));
                registerDisposable(this.Bind(ViewModel, 
                                             x => x.Priezvisko, 
                                             x => x.TxtPriezvisko.Text));
                registerDisposable(this.Bind(ViewModel, 
                                             x => x.CeleMeno, 
                                             x => x.LblCeleMeno.Text));

                registerDisposable(this.Bind(ViewModel,
                                             x => x.Number1,
                                             x => x.TxtNumber1.Text,
                                             x => x.ToString(),
                                             x => x.TryParseIntOrDefault()));
                registerDisposable(this.Bind(ViewModel,
                                             x => x.Number2,
                                             x => x.TxtNumber2.Text,
                                             x => x.ToString(),
                                             x => x.TryParseIntOrDefault()));
                registerDisposable(this.Bind(ViewModel,
                                             x => x.AdditionResult,
                                             x => x.TxtAdditionResult.Text));
            });

        }

        #region Prvky z interfejsu IViewFor<TViewModel>
        
        public MainViewModel ViewModel { get; set; } = new MainViewModel();

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = value as MainViewModel; }
        }                       

        #endregion

    }
}
