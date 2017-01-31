using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncProgramming
{
    public partial class ReportProgress : Form
    {
        public ReportProgress()
        {
            InitializeComponent();
        }

        private async void btnReportProgressTask_Click(object sender, EventArgs e)
        {
            var progress = new Progress<double>();
            progress.ProgressChanged += (send, args) =>
            {
                txtResult.Text = txtResult.Text + Environment.NewLine + args.ToString();
            };

            await DownloadFile(progress);

            MessageBox.Show("file downloaded.");
        }

        private async Task DownloadFile(IProgress<double> progress = null)
        {
            double percentComplete = 0;
            bool done = false;
            while(!done)
            {
                await Task.Delay(1000);
                percentComplete = percentComplete + 10;
                if(percentComplete ==100)
                    done= true;

                if (progress != null)
                    progress.Report(percentComplete);
            }
        }
    }
}
