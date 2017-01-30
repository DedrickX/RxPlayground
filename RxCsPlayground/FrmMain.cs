using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RxCsPlayground
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            //TxtInput.TextChanged += InputTextChanged;
            InitObservable();
        }


        #region Pomocné metódy

        /// <summary>
        /// Výpis do výstupného textboxu
        /// </summary>
        private void WriteToOutput(string text)
        {
            TxtOtuput.AppendText(text + Environment.NewLine);
        }

        #endregion


        #region Klasický event

        /// <summary>
        /// Klasická metóda EventHandlera
        /// </summary>
        private void InputTextChanged(object sender, EventArgs e)
        {            
            WriteToOutput((sender as TextBox)?.Text);
        }

        #endregion


        #region Observable riešenie

        private IDisposable textChangedSubscription;

        private void InitObservable()
        {
            var textChangedStream = Observable
                .FromEventPattern<EventArgs>(TxtInput, "TextChanged")
                .Select((x) => (x.Sender as TextBox)?.Text);

            textChangedSubscription = textChangedStream
                .Subscribe((x) => WriteToOutput(x));
        }

        #endregion

    }
}
