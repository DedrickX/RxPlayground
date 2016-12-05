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
               

        #region Ctor

        public MainView()
        {
            InitializeComponent();
                    
            ViewModel = new MainViewModel();
        }

        #endregion


        #region ViewModel

        public MainViewModel ViewModel { get; set; } 


        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = value as MainViewModel; }
        }

        #endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Bind(ViewModel, 
                      x => x.Meno, 
                      x => x.TxtMeno.Text);

            this.Bind(ViewModel,
                      x => x.Priezvisko,
                      x => x.TxtPriezvisko.Text);

        }

    }
}
