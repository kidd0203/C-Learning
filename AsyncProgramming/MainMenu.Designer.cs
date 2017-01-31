namespace AsyncProgramming
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPauseAsync = new System.Windows.Forms.Button();
            this.btnRtnComTask = new System.Windows.Forms.Button();
            this.btnReportProgress = new System.Windows.Forms.Button();
            this.btnProcessTAsComplete = new System.Windows.Forms.Button();
            this.btnHandleException = new System.Windows.Forms.Button();
            this.btnCancelDuetoTimeout = new System.Windows.Forms.Button();
            this.btnTaskCancellation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPauseAsync
            // 
            this.btnPauseAsync.Location = new System.Drawing.Point(12, 36);
            this.btnPauseAsync.Name = "btnPauseAsync";
            this.btnPauseAsync.Size = new System.Drawing.Size(102, 23);
            this.btnPauseAsync.TabIndex = 0;
            this.btnPauseAsync.Text = "PauseAsync";
            this.btnPauseAsync.UseVisualStyleBackColor = true;
            this.btnPauseAsync.Click += new System.EventHandler(this.btnPauseAsync_Click);
            // 
            // btnRtnComTask
            // 
            this.btnRtnComTask.Location = new System.Drawing.Point(133, 36);
            this.btnRtnComTask.Name = "btnRtnComTask";
            this.btnRtnComTask.Size = new System.Drawing.Size(139, 23);
            this.btnRtnComTask.TabIndex = 1;
            this.btnRtnComTask.Text = "ReturnCompletedTask";
            this.btnRtnComTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRtnComTask.UseVisualStyleBackColor = true;
            this.btnRtnComTask.Click += new System.EventHandler(this.btnRtnComTask_Click);
            // 
            // btnReportProgress
            // 
            this.btnReportProgress.Location = new System.Drawing.Point(12, 76);
            this.btnReportProgress.Name = "btnReportProgress";
            this.btnReportProgress.Size = new System.Drawing.Size(102, 23);
            this.btnReportProgress.TabIndex = 2;
            this.btnReportProgress.Text = "ReportProgress";
            this.btnReportProgress.UseVisualStyleBackColor = true;
            this.btnReportProgress.Click += new System.EventHandler(this.btnReportProgress_Click);
            // 
            // btnProcessTAsComplete
            // 
            this.btnProcessTAsComplete.Location = new System.Drawing.Point(133, 76);
            this.btnProcessTAsComplete.Name = "btnProcessTAsComplete";
            this.btnProcessTAsComplete.Size = new System.Drawing.Size(139, 23);
            this.btnProcessTAsComplete.TabIndex = 3;
            this.btnProcessTAsComplete.Text = "ProcessTaskAsItComplete";
            this.btnProcessTAsComplete.UseVisualStyleBackColor = true;
            this.btnProcessTAsComplete.Click += new System.EventHandler(this.btnProcessTAsComplete_Click);
            // 
            // btnHandleException
            // 
            this.btnHandleException.Location = new System.Drawing.Point(12, 117);
            this.btnHandleException.Name = "btnHandleException";
            this.btnHandleException.Size = new System.Drawing.Size(102, 23);
            this.btnHandleException.TabIndex = 4;
            this.btnHandleException.Text = "HandleException";
            this.btnHandleException.UseVisualStyleBackColor = true;
            this.btnHandleException.Click += new System.EventHandler(this.btnHandleException_Click);
            // 
            // btnCancelDuetoTimeout
            // 
            this.btnCancelDuetoTimeout.Location = new System.Drawing.Point(133, 117);
            this.btnCancelDuetoTimeout.Name = "btnCancelDuetoTimeout";
            this.btnCancelDuetoTimeout.Size = new System.Drawing.Size(139, 23);
            this.btnCancelDuetoTimeout.TabIndex = 5;
            this.btnCancelDuetoTimeout.Text = "CancelDuetoTimeout";
            this.btnCancelDuetoTimeout.UseVisualStyleBackColor = true;
            this.btnCancelDuetoTimeout.Click += new System.EventHandler(this.btnCancelDuetoTimeout_Click);
            // 
            // btnTaskCancellation
            // 
            this.btnTaskCancellation.Location = new System.Drawing.Point(12, 156);
            this.btnTaskCancellation.Name = "btnTaskCancellation";
            this.btnTaskCancellation.Size = new System.Drawing.Size(102, 23);
            this.btnTaskCancellation.TabIndex = 6;
            this.btnTaskCancellation.Text = "TaskCancellation";
            this.btnTaskCancellation.UseVisualStyleBackColor = true;
            this.btnTaskCancellation.Click += new System.EventHandler(this.btnTaskCancellation_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTaskCancellation);
            this.Controls.Add(this.btnCancelDuetoTimeout);
            this.Controls.Add(this.btnHandleException);
            this.Controls.Add(this.btnProcessTAsComplete);
            this.Controls.Add(this.btnReportProgress);
            this.Controls.Add(this.btnRtnComTask);
            this.Controls.Add(this.btnPauseAsync);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPauseAsync;
        private System.Windows.Forms.Button btnRtnComTask;
        private System.Windows.Forms.Button btnReportProgress;
        private System.Windows.Forms.Button btnProcessTAsComplete;
        private System.Windows.Forms.Button btnHandleException;
        private System.Windows.Forms.Button btnCancelDuetoTimeout;
        private System.Windows.Forms.Button btnTaskCancellation;
    }
}