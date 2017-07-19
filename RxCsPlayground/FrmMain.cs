using System;
using System.Windows.Forms;


namespace RxCsPlayground
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

                
        private void BtnTest_Click(object sender, EventArgs e)
        {
            var frm = new FrmTest();
            frm.Show();
        }

        
        private void BtnCities_Click(object sender, EventArgs e)
        {
            var frm = new Cities.FrmCities(new Cities.CitiesRepository());
            frm.Show();
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            var frm = new Input.FrmInput();
            frm.Show();
        }
    }
}
