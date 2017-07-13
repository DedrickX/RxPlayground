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
            var results = from searchTerm in inputStream
                          from result in _itemsSource.GetItems(searchTerm)
                          select result;

            // sledujeme stream výsledkov a výsledky plníme do ListBoxu
            _resultsSubscription = results
                .ObserveOn(this)
                .Subscribe(result => FillResultItems(result));
        }
                        
                
        private void FillResultItems(PaginatedSearchResult searchResult)
        {
            if (searchResult is SearchResult_StartingNewStream)
            {
                ListResults.Items.Clear();
            }
            else
            {
                var itemsResult = searchResult as SearchResult_ReturningItems;
                ListResults.Items.AddRange(itemsResult.Items.ToArray());
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
