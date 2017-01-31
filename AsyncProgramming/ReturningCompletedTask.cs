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
    public partial class ReturningCompletedTask : Form
    {
        public ReturningCompletedTask()
        {
            InitializeComponent();
        }

        private async void btnRtnValue_Click(object sender, EventArgs e)
        {
            var taskWithReturnedValue = await Task.Factory.StartNew(async () =>
            {
                await Task.Delay(2000);
                return Task.FromResult("task completed.");
            });

            var result = (await taskWithReturnedValue).Result;

            MessageBox.Show(result);
        }

        private async void btnRtnException_Click(object sender, EventArgs e)
        {
            var taskWithException = await Task.Factory.StartNew(() => {
                var tcs = new TaskCompletionSource<string>();
                tcs.SetException(new NotImplementedException());
                return tcs.Task;
            });

            try
            {
                await taskWithException;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
