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
        private ItemsSource _itemsSource = new ItemsSource();

        private IDisposable _searchTextStreamSubscription;

        public FrmSearchBox()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            var searchTextStream = Observable
                .FromEventPattern<EventArgs>(TxtSearch, nameof(TxtSearch.TextChanged))
                .Select(args => (args.Sender as TextBox).Text);

            _searchTextStreamSubscription = searchTextStream
               .ObserveOn(this)
               .Subscribe(x => FillItems(_itemsSource.GetItems(x)));
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _searchTextStreamSubscription.Dispose();
        }

        private void FillItems(List<string> items)
        {
            ListResults.Items.Clear();
            ListResults.Items.AddRange(items.ToArray());
        }
    }       
}
