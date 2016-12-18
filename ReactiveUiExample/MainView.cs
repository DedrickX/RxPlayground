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
    public partial class MainView : Form, IViewFor<MainViewModel>
    {

        public MainView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.Bind(ViewModel, x => x.Meno, x => x.TxtMeno.Text));
                d(this.Bind(ViewModel, x => x.Priezvisko, x => x.TxtPriezvisko.Text));
                d(this.Bind(ViewModel, x => x.CeleMeno, x => x.LblCeleMeno.Text));                
            });

        }

        public MainViewModel ViewModel { get; set; } = new MainViewModel();

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = value as MainViewModel; }
        }

    }
}
