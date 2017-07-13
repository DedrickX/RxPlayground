using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RxCsPlayground.PaginatedSearchBox
{
    public partial class FrmPaginatedSearchBox : Form
    {

        private IPaginatedItemsSource _itemsSource;

        private IDisposable _resultsSubscription;
        

        #region Ctor

        public FrmPaginatedSearchBox(IPaginatedItemsSource itemsSource)
        {
            InitializeComponent();

            _itemsSource = itemsSource;
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
                          from result in _itemsSource.GetItems(searchTerm).TakeUntil(inputStream)
                          select result;

            // sledujeme stream výsledkov a výsledky plníme do ListBoxu
            _resultsSubscription = searchResultStream
                .ObserveOn(this)
                .Subscribe(result => FillResultItems(result), 
                           ex => LblProgressInfo.Text = $"Pri vyhľadávaní vznihka chyba {ex.Message}!",
                           () => LblProgressInfo.Text = "Vyhľadávanie dokončené.");
        }
                        
                
        private void FillResultItems(PaginatedSearchResult searchResult)
        {
            Debug.Print($"FillResultItems ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                        
            if (searchResult is SearchResult_StartingNewStream)
            {
                var newStreamResult = searchResult as SearchResult_StartingNewStream;
                ListResults.Items.Clear();
                LblProgressInfo.Text = $"Hľadám položky obsahujúce {newStreamResult.SearchTerm}...";
            }
            else
            {
                var itemsResult = searchResult as SearchResult_ReturningItems;
                ListResults.Items.AddRange(itemsResult.Items.ToArray());
                LblProgressInfo.Text = $"Zobrazujem položky obsahujúce {itemsResult.SearchTerm}, stránka {itemsResult.PageNr}...";
            }
        }


        private void DisposeStreams()
        {
            // ukončenie sledovania streamov            
            _resultsSubscription.Dispose();
        }


        #endregion

    }
}
