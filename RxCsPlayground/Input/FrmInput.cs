using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RxCsPlayground.Input
{
    public partial class FrmInput : Form
    {

        /// <summary>
        /// Scheduler prezentačnej vrstvy - tu môžem pracovať s prvkami formulára
        /// </summary>
        private IScheduler _uiScheduler;
        
        
        // Kontrakty odberu zo streamov        
        private IDisposable _inputSubscription;        
        

        #region Konštruktor


        public FrmInput()
        {
            InitializeComponent();

            // inicializujem inštancie schedulerov            
            _uiScheduler = new ControlScheduler(this);
        }


        #endregion


        #region Hlavné eventy


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // inicializácia streamov
            InitStreams();
        }


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // ukončenie streamov
            DisposeStreams();
        }


        #endregion


        /// <summary>
        /// Inicializácia streamov pri Load evente formulára
        /// </summary>
        private void InitStreams()
        {
            // stream emitujúci hodnoty pri zmene textu - emituje text z textBoxu
            var textChangedStream = Observable
                .FromEventPattern<EventArgs>(TxtInput, nameof(TxtInput.TextChanged))
                .Select(args => (args.Sender as TextBox).Text);

            // stream emitujúci hodnoty pri zmene textu - oneskorená hodnota
            var textChangedStreamThrottled = textChangedStream
                .Where(x => x.Length > 3)
                .Throttle(x => ThrottleDurationGenerator(x.Length));

            // stream emitujúci text v okamihu ako je v texte napísané KROS
            var textChangedStreamKros = textChangedStream
                .Where(x => x.Trim().ToLower().Contains("kros"));
            
            // stream emitujúci hodnoty po stlačení tlačidla Enter - emituje text z textBoxu
            var enterPressedStream = Observable
                .FromEventPattern<KeyEventArgs>(TxtInput, nameof(TxtInput.KeyDown))
                .Where(args => args.EventArgs.KeyCode == Keys.Enter)
                .Select(args => (args.Sender as TextBox).Text);
            
            var inputStream = textChangedStreamThrottled
                .Merge(textChangedStreamKros)
                .Merge(enterPressedStream)
                .DistinctUntilChanged();

            _inputSubscription = inputStream
                .ObserveOn(_uiScheduler)
                .Subscribe(x => WriteToOutput(x));
        }


        /// <summary>
        /// Funkcia ktorá podľa dĺžky textu vytvorí "časovací" stream - taký ktorý emitne práve jednu hodnotu po presne danom čase
        /// </summary>
        /// <remarks>
        /// 4 písmená = 1200 ms
        /// 5 písmen  = 1000 ms
        /// 6 písmen  =  800 ms
        /// 7 písmen  =  600 ms
        /// 8 písmen  =  400 ms
        /// 9 písmen  =  200 ms
        /// 10 písmen =  100 ms
        /// </remarks>
        private IObservable<long> ThrottleDurationGenerator(int textLength)
        {                        
            var delay = (textLength < 10) 
                ? (10 - textLength) * 200
                : 100;

            return Observable.Timer(TimeSpan.FromMilliseconds(delay));
        }



        /// <summary>
        /// Dispose odberov zo streamov
        /// </summary>
        private void DisposeStreams()
        {
            // ukončenie sledovania streamov
            _inputSubscription?.Dispose();         
        }



        #region Tools


        /// <summary>
        /// Vypísanie hodnoty do výstupu aj s časovou pečiatkou
        /// </summary>        
        private void WriteToOutput(string text)
        {

            WriteColoredText(DateTime.Now.ToString("HH:mm:ss fff") + " - ", Color.LightBlue);
            WriteColoredText(text + Environment.NewLine, Color.Black);
        }


        /// <summary>
        /// Vypísanie farebného textu do textBoxu s výstupom
        /// </summary>        
        private void WriteColoredText(string text, Color color)
        {
            TxtOutput.SelectionStart = TxtOutput.TextLength;
            TxtOutput.SelectionLength = 0;

            TxtOutput.SelectionColor = color;
            TxtOutput.AppendText(text);
            TxtOutput.SelectionColor = TxtOutput.ForeColor;
            TxtOutput.ScrollToCaret();
        }


        /// <summary>
        /// Vyčistenie výstupu tlačidlom
        /// </summary>        
        private void BtnClearOutput_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
        }



        #endregion

    }
}
