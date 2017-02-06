using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RxCsPlayground
{
    public partial class FrmSchedulers : Form
    {
        

        public FrmSchedulers()
        {
            InitializeComponent();

            // vypíšeme si id hlavného vlákna UI
            PrintThreadId("UI");

            var clickStream = Observable.FromEventPattern(this.button1, "Click");
                //.Delay(TimeSpan.FromMilliseconds(100));

            clickStream.Subscribe(
                x => 
                {
                    // vypíšeme id vlákna na ktorom sme získali oznam o kliku
                    PrintThreadId("Subscribed on");
                    // aktualizujeme UI
                    UpdateTextBox();
                });
        }


        /// <summary>
        /// Vypíše číslo vlákna do Debug výstupu
        /// </summary>        
        private void PrintThreadId(string text)
        {
            Debug.Print($"{text} thread #{Thread.CurrentThread.ManagedThreadId}");
        }

        /// <summary>
        /// Aktualizuje textbox - pridá nový riadok s oznamom že prebehol click
        /// </summary>
        private void UpdateTextBox()
        {
            TxtOtuput.AppendText("Click!\n");
        }
    }
}
