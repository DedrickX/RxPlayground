using RxCsPlayground.PaginatedSearchBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RxCsPlayground
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void BtnTextChangedExample_Click(object sender, EventArgs e)
        {
            var frm = new FrmTextChangedExample();
            frm.Show();
        }

        private void BtnSchedulers_Click(object sender, EventArgs e)
        {
            var frm = new FrmSchedulers();
            frm.Show();
        }

        private void BtnAsyncSearchBox_Click(object sender, EventArgs e)
        {
            var frm = new FrmSearchBox(new ItemsSource());
            frm.Show();
        }

        private void BtnPaginatedAsyncSearchBox_Click(object sender, EventArgs e)
        {
            var frm = new FrmPaginatedSearchBox(new PaginatedItemsSource());
            frm.Show();
        }

    }
}
