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

namespace RxCsPlayground.Cities
{
    public partial class FrmCities : Form
    {

        private ICitiesRepository _repository;

        private IDisposable _resultsSubscription;

        private IScheduler _asyncScheduler;
        

        #region Konštruktor


        public FrmCities(ICitiesRepository repository)
        {
            InitializeComponent();

            _repository = repository;
            _asyncScheduler = Scheduler.NewThread;
        }


        #endregion


        #region Form eventHandlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitStreams();
        }


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            DisposeStreams();
        }

        #endregion


        #region Search members


        private void InitStreams()
        {
            Debug.Print($"Form ThreadId: {Thread.CurrentThread.ManagedThreadId}");

            // stream z eventu TextChanged
            var textChangedStream = Observable
                .FromEventPattern<EventArgs>(TxtSearch, nameof(TxtSearch.TextChanged))
                .Throttle(TimeSpan.FromSeconds(1))
                .Select(args => (args.Sender as TextBox).Text);

            // stream z eventu stlačenia tlačidla Enter
            var enterPressedStream = Observable
                .FromEventPattern<KeyEventArgs>(TxtSearch, nameof(TxtSearch.KeyDown))
                .Where(args => args.EventArgs.KeyCode == Keys.Enter)
                .Select(args => (args.Sender as TextBox).Text);

            // stream predstavujúci pokyn na vyhľadávanie textu 
            var inputStream = textChangedStream
                .Merge(enterPressedStream)
                .DistinctUntilChanged();

            // vytvoríme stream výsledkov asynchrónneho vyhľadávania zo streamu vyhľadávaného textu
            var searchResultStream = from searchTerm in inputStream
                                     from result in _repository
                                                    .GetCities(searchTerm)
                                                    .SubscribeOn(_asyncScheduler)
                                                    .TakeUntil(inputStream)
                                     select result;

            // sledujeme stream výsledkov a výsledky plníme do ListBoxu
            _resultsSubscription = searchResultStream
                .ObserveOn(this)
                .Subscribe(result => FillCities(result),
                           ex => LblProgressInfo.Text = $"Pri vyhľadávaní vznihka chyba {ex.Message}!",
                           () => LblProgressInfo.Text = "Vyhľadávanie dokončené.");
        }


        private void FillCities(CitiesStreamItem searchResult)
        {
            Debug.Print($"FillCities ThreadId: {Thread.CurrentThread.ManagedThreadId}");

            if (searchResult.Page == 0)
                ListResults.Items.Clear();

            ListResults.Items.AddRange(searchResult.Cities.ToArray());
        }


        private void DisposeStreams()
        {
            // ukončenie sledovania streamov            
            _resultsSubscription.Dispose();
        }


        #endregion

    }
}
