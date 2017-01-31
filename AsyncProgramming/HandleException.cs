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
    public partial class HandleException : Form
    {
        public HandleException()
        {
            InitializeComponent();
        }
        private async Task TaskThrowException()
        {
            await Task.Delay(1000);
            throw new NotImplementedException();
        }

        private async Task TaskThrowExceptionHighLevel()
        {
            try
            {
                await TaskThrowException();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw new Exception(message);
            }
            
        }
        private async void btnHandleException_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    await TaskThrowException();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            Task t = TaskThrowExceptionHighLevel();

            try
            {
                await t;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
