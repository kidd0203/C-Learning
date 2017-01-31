using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncProgramming
{
    public partial class TaskCancellation : Form
    {
        CancellationTokenSource ts = new CancellationTokenSource();
        
        public TaskCancellation()
        {
            InitializeComponent();
        }

        private async Task DownloadFile(CancellationToken token ,IProgress<double> progress = null)
        {
            double percentComplete = 0;
            bool done = false;
            while (!done)
            {
                if (!token.IsCancellationRequested) // check whether the task cancellation has been requested.
                {
                    await Task.Delay(1000);
                    percentComplete = percentComplete + 10;
                    if (percentComplete == 100)
                        done = true;

                    if (progress != null)
                        progress.Report(percentComplete);    
                }
                else
                {
                    // throw exception if task is cancelled. 
                    throw new Exception("Task is cancelled.");
                }
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            var progress = new Progress<double>();
            
            progress.ProgressChanged += (send, args) =>
            {
                txtResult.Text = txtResult.Text + Environment.NewLine + args.ToString();
            };

            try
            {
                Task t = DownloadFile(ts.Token, progress);
                await t;

                MessageBox.Show("file downloaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ts.Cancel();
        }
    }
}
