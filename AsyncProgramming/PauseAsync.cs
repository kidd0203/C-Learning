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
    public partial class PauseAsync : Form
    {
        public PauseAsync()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // both method 1 and 2 work. but method 3 doesn't work. there is no pause at all.
            //method 1
            //await Task.Delay(Convert.ToInt32(txtSeconds.Text));

            //method 2
            Task a = await Task.Factory.StartNew(async () =>
            {
                await Task.Delay(Convert.ToInt32(txtSeconds.Text));
            });
            await a;

            //method3 
            //await Task.Factory.StartNew(() =>
            //{
            //    Task.Delay(Convert.ToInt32(txtSeconds.Text));
            //});


            MessageBox.Show(string.Format("Waited for {0} milliseconds.", txtSeconds.Text));
        }

        private async void btnTaskTimeout_Click(object sender, EventArgs e)
        {
            var taskTimeout = await Task.Factory.StartNew(async () =>
            {
                await Task.Delay(Convert.ToInt32(txtTimeoutMillisecond.Text));
            });

            var taskFileDownload = await Task.Factory.StartNew(async () => {
                await Task.Delay(Convert.ToInt32(txtTaskMillisecond.Text));
                return Task.FromResult("file has been downloaded from online.");
                //return "file has been downloaded from online.";
            });

            var completedTask = await Task.WhenAny(taskTimeout, taskFileDownload);

            if (completedTask == taskTimeout)
            {
                MessageBox.Show("Timeout.");
            }
            else
            {
                string result = (await taskFileDownload).Result;
                MessageBox.Show(result);
            }
        }
    }
}
