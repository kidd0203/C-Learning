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
    public partial class CancellationDueToTimeout : Form
    {
        public CancellationDueToTimeout()
        {
            InitializeComponent();
        }

        private async Task IssueTimeoutAsync()
        {
            int timeout = Convert.ToInt32(txtTimeoutMillisecond.Text);
            int taskruntime = Convert.ToInt32(txtTaskMillisecond.Text);
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            cts.CancelAfter(timeout);

            await Task.Delay(taskruntime, token);
        }

        private async void btnTaskTimeout_Click(object sender, EventArgs e)
        {

            try
            {
                await IssueTimeoutAsync(); // exception will be thrown when the task is cancelled due to time out.
                MessageBox.Show("Task completed without any cancellation.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
