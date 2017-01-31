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
    public partial class ProcessTasksAsTheyComplete : Form
    {
        public ProcessTasksAsTheyComplete()
        {
            InitializeComponent();
        }

        private async Task<int> DelayAndReturnAsync(int val)
        {
            await Task.Delay(TimeSpan.FromSeconds(val));
            return val;
        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            var taskA = DelayAndReturnAsync(2);
            var taskB = DelayAndReturnAsync(1);
            var taskC = DelayAndReturnAsync(3);

            var tasks = new[] { taskA, taskB, taskC };

            var processingTasks = tasks.Select(async t =>
            {
                var result = await t;

                this.BeginInvoke((Action)(() =>
                {
                    txtResult.Text = txtResult.Text + Environment.NewLine + result;
                }));
            }).ToArray();

            await Task.WhenAll(processingTasks);
        }

        private async void btnSync_Click(object sender, EventArgs e)
        {
            var taskA = DelayAndReturnAsync(2);
            var taskB = DelayAndReturnAsync(1);
            var taskC = DelayAndReturnAsync(3);

            var tasks = new[] { taskA, taskB, taskC };

            // await each task in sequence order, even though the second task in the sequence is the first one to complete.
            foreach (var t in tasks)
            {
                var result = await t;

                this.BeginInvoke((Action)(() =>
                {
                    txtResult.Text = txtResult.Text + Environment.NewLine + result;
                }));
            }
        }
    }
}
