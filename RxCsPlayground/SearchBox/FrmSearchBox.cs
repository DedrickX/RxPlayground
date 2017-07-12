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

namespace RxCsPlayground
{
    public partial class FrmSearchBox : Form
    {

        private ItemsSource _itemsSource;

        private IDisposable _resultsSubscription;
        private IDisposable _searchInProgressSubscription;
        

        #region Ctor

        public FrmSearchBox(ItemsSource itemsSource)
        {
            InitializeComponent();

            _itemsSource = itemsSource;
        }

        #endregion


        #region Form event handlers

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

            // akonáhle sme dali pokyn na vyhľadávanie, oznámime to na formulári
            _searchInProgressSubscription = inputStream
                .ObserveOn(this)
                .Subscribe(searchTerm => PromptSearchInProgress(searchTerm));

            // z funkcie GetItems sme si urobili zdroj asynchrónneho streamu
            var observableSearch = Observable
                .ToAsync<string, SearchResult>(_itemsSource.GetItems);

            // vytvoríme stream výsledkov asynchrónneho vyhľadávania zo streamu vyhľadávaného textu
            var results = from searchTerm in inputStream
                          from result in observableSearch(searchTerm).TakeUntil(inputStream)
                          select result;

            // sledujeme stream výsledkov a výsledky plníme do ListBoxu
            _resultsSubscription = results
                .ObserveOn(this)
                .Subscribe(result => FillResultItems(result.Items));
        }


        private void DisposeStreams()
        {
            // ukončenie sledovania streamov
            _searchInProgressSubscription.Dispose();
            _resultsSubscription.Dispose();
        }
        

        private void PromptSearchInProgress(string searchText)
        {
            ListResults.Items.Clear();
            ListResults.Items.Add(string.IsNullOrWhiteSpace(searchText)
                ? $"... Zobrazujem všetky položky ..."
                : $"... Hľadám položky obsahujúce {searchText} ...");
        }

        private void FillResultItems(IEnumerable<string> items)
        {
            ListResults.Items.Clear();
            ListResults.Items.AddRange(items.ToArray());
        }
        
        #endregion

    }       
}
