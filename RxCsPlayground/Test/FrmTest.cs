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
    public partial class FrmTest : Form
    {
        private IDisposable _subscription;        

        public FrmTest()
        {
            InitializeComponent();            
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var clickStream = Observable.FromEventPattern(this.button1, "Click");

            var numbersStream = from click in clickStream
                                from number in GetNumbers().TakeUntil(clickStream)
                                select number;

            _subscription = numbersStream
                    .ObserveOn(this)
                    .Subscribe(x => Debug.Print(x.ToString() + System.Environment.NewLine),
                               err => PrintText("NumbersStream Error!"),
                               () => PrintText("NumbersStream Done"));

            //_subscription = clickStream
            //    .Subscribe(x => { PrintText("ClickStream - New numbers stream");
            //                      SubscribeForNumbers(clickStream); },
            //               err => PrintText("ClickStream Error!"),
            //               () => PrintText("ClickStream Done"));                        
        }


        protected IObservable<long> GetNumbers()
        {
            return Observable.Generate<long, long>(0,
                    x => x < 10,
                    x => { Thread.Sleep(500); return x + 1; },
                    x => x, Scheduler.Default);                

        }


        protected void SubscribeForNumbers(IObservable<System.Reactive.EventPattern<object>> until)
        {
            //_numbersSubscription = GetNumbers()
            //    .ObserveOn(this)
            //    .TakeUntil(until)
            //    .Subscribe(x => PrintText($"#{x}"),
            //               err => PrintText("NumbersStream Error!"),
            //               () => PrintText("NumbersStream Done"));
        }
                        

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
                        
            _subscription?.Dispose();

        }
        

        /// <summary>
        /// Aktualizuje textbox - pridá nový riadok s oznamom že prebehol click
        /// </summary>
        private void PrintText(string text)
        {
            TxtOtuput.AppendText(text + Environment.NewLine);
        }

    }
}
