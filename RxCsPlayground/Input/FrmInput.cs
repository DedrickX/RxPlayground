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
        private IDisposable _textChangedSubscription;
        private IDisposable _enterPressedSubscription;


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
                .Select(args => TxtInput.Text)
                .Where(x => x.Length > 3);

            _textChangedSubscription = textChangedStream
                .Subscribe(x => WriteLineToOutput($"TextChanged - {x}", Color.LightBlue));

            // stream emitujúci hodnoty po stlačení tlačidla Enter - emituje text z textBoxu
            var enterPressedStream = Observable
                .FromEventPattern<KeyEventArgs>(TxtInput, nameof(TxtInput.KeyDown))
                .Where(args => args.EventArgs.KeyCode == Keys.Enter)
                .Select(args => TxtInput.Text);

            _enterPressedSubscription = enterPressedStream
                .Subscribe(x => WriteLineToOutput($"EnterPressed - {x}", Color.LightGreen));

            var inputStream = textChangedStream
                .Merge(enterPressedStream)
                .DistinctUntilChanged();

            _inputSubscription = inputStream
                .Subscribe(x => WriteLineToOutput($"{x}", Color.Red));
        }


        /// <summary>
        /// Dispose odberov zo streamov
        /// </summary>
        private void DisposeStreams()
        {
            // ukončenie sledovania streamov
            _inputSubscription?.Dispose();
            _textChangedSubscription?.Dispose();
            _enterPressedSubscription?.Dispose();
        }


        /// <summary>
        /// Vypísanie farebného textu do textBoxu s výstupom
        /// </summary>        
        private void WriteLineToOutput(string text, Color color)
        {
            TxtOutput.SelectionStart = TxtOutput.TextLength;
            TxtOutput.SelectionLength = 0;

            TxtOutput.SelectionColor = color;
            TxtOutput.AppendText($"{DateTime.Now.ToShortTimeString()}: {text}{System.Environment.NewLine}");
            TxtOutput.SelectionColor = TxtOutput.ForeColor;
            TxtOutput.ScrollToCaret();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
        }


    }
}
