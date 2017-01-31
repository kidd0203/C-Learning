namespace AsyncProgramming
{
    partial class ReportProgress
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnReportProgressTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(180, 185);
            this.txtResult.TabIndex = 3;
            // 
            // btnReportProgressTask
            // 
            this.btnReportProgressTask.Location = new System.Drawing.Point(13, 217);
            this.btnReportProgressTask.Name = "btnReportProgressTask";
            this.btnReportProgressTask.Size = new System.Drawing.Size(179, 23);
            this.btnReportProgressTask.TabIndex = 4;
            this.btnReportProgressTask.Text = "StartTask";
            this.btnReportProgressTask.UseVisualStyleBackColor = true;
            this.btnReportProgressTask.Click += new System.EventHandler(this.btnReportProgressTask_Click);
            // 
            // ReportProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 283);
            this.Controls.Add(this.btnReportProgressTask);
            this.Controls.Add(this.txtResult);
            this.Name = "ReportProgress";
            this.Text = "ReportProgress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnReportProgressTask;
    }
}