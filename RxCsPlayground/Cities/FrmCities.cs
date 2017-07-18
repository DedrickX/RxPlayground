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

        private IDisposable _searchTermSubscription;
        private IDisposable _resultsSubscription;

        private IScheduler _uiScheduler;
        private IScheduler _nextThreadScheduler;
        

        #region Konštruktor


        public FrmCities(ICitiesRepository repository)
        {
            InitializeComponent();

            _repository = repository;

            _nextThreadScheduler = new NewThreadScheduler();
            _uiScheduler = new ControlScheduler(this);
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
            Debug.Print($"Štart UI, ThreadId: {Thread.CurrentThread.ManagedThreadId}");

            // 1 - stream z eventu TextChanged
            var textChangedStream = Observable
                .FromEventPattern<EventArgs>(TxtSearch, nameof(TxtSearch.TextChanged))
                .Throttle(TimeSpan.FromSeconds(0.5))
                .Select(args => (args.Sender as TextBox).Text);

            // 2 - stream z eventu stlačenia tlačidla Enter
            var enterPressedStream = Observable
                .FromEventPattern<KeyEventArgs>(TxtSearch, nameof(TxtSearch.KeyDown))
                .Where(args => args.EventArgs.KeyCode == Keys.Enter)
                .Select(args => (args.Sender as TextBox).Text);

            var searchTermStream = textChangedStream
                .Merge(enterPressedStream) // Merge je paralelné spojenie streamov                
                .DistinctUntilChanged()
                .ObserveOn(_nextThreadScheduler);

            // prihlásim sa na odber požiadaviek na vyhľadávanie
            _searchTermSubscription = searchTermStream
                .Subscribe(
                    term => 
                    {
                        Console.WriteLine($"Vyhľadávam \"{term}\", ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                        _resultsSubscription = _repository.GetCities(term)                            
                            .TakeUntil(searchTermStream)
                            .ObserveOn(_uiScheduler)
                            .Subscribe(result => 
                                FillCities(result), 
                                ShowErrorInfo, 
                                () =>
                                {
                                    Debug.Print($"Vyhľadávanie dokončené, ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                                    ShowInfoText("Vyhľadávanie dokončené.");
                                }
                            );
                    }, 
                    ShowErrorInfo);
        }


        private void ShowInfoText(string text) =>
            LblProgressInfo.Text = text;


        private void ShowErrorInfo(Exception ex) =>
            ShowInfoText($"Pri vyhľadávaní vznikla chyba {ex.Message}!");
        

        private void FillCities(CitiesStreamItem searchResult)
        {
            Debug.Print($"Napĺňam výsledky - stránka {searchResult.Page}, ThreadId: {Thread.CurrentThread.ManagedThreadId}");

            if (searchResult.Page == 0)
                ListResults.Items.Clear();

            ListResults.Items.AddRange(searchResult.Cities.ToArray());
        }


        private void DisposeStreams()
        {
            // ukončenie sledovania streamov            
            _searchTermSubscription?.Dispose();
            _resultsSubscription?.Dispose();
        }


        #endregion

    }
}
