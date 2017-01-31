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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPauseAsync_Click(object sender, EventArgs e)
        {
            PauseAsync f = new PauseAsync();
            f.ShowDialog();
        }

        private void btnRtnComTask_Click(object sender, EventArgs e)
        {
            ReturningCompletedTask f = new ReturningCompletedTask();
            f.ShowDialog();
        }

        private void btnReportProgress_Click(object sender, EventArgs e)
        {
            ReportProgress f = new ReportProgress();
            f.ShowDialog();
        }

        private void btnProcessTAsComplete_Click(object sender, EventArgs e)
        {
            ProcessTasksAsTheyComplete f = new ProcessTasksAsTheyComplete();
            f.ShowDialog();
        }

        private void btnHandleException_Click(object sender, EventArgs e)
        {
            HandleException f = new HandleException();
            f.ShowDialog();
        }

        private void btnCancelDuetoTimeout_Click(object sender, EventArgs e)
        {
            CancellationDueToTimeout f = new CancellationDueToTimeout();
            f.ShowDialog();
        }

        private void btnTaskCancellation_Click(object sender, EventArgs e)
        {
            TaskCancellation f = new TaskCancellation();
            f.ShowDialog();
        }
    }
}
