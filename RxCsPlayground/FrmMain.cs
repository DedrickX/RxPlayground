using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var subject = new ReplaySubject<string>();            
            subject.OnNext("a");
            WriteSequenceToOutput(subject);
            subject.OnNext("b");
            subject.OnNext("c");            
        }


        void WriteSequenceToOutput(IObservable<string> sequence)
        {
            sequence.Subscribe(TxtOutput.AppendText);
        }


    }
}
