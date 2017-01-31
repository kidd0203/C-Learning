namespace AsyncProgramming
{
    partial class CancellationDueToTimeout
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaskMillisecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeoutMillisecond = new System.Windows.Forms.TextBox();
            this.btnTaskTimeout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Task:";
            // 
            // txtTaskMillisecond
            // 
            this.txtTaskMillisecond.Location = new System.Drawing.Point(94, 43);
            this.txtTaskMillisecond.Name = "txtTaskMillisecond";
            this.txtTaskMillisecond.Size = new System.Drawing.Size(62, 20);
            this.txtTaskMillisecond.TabIndex = 10;
            this.txtTaskMillisecond.Text = "2000";
            this.txtTaskMillisecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Timeout:";
            // 
            // txtTimeoutMillisecond
            // 
            this.txtTimeoutMillisecond.Location = new System.Drawing.Point(94, 21);
            this.txtTimeoutMillisecond.Name = "txtTimeoutMillisecond";
            this.txtTimeoutMillisecond.Size = new System.Drawing.Size(62, 20);
            this.txtTimeoutMillisecond.TabIndex = 8;
            this.txtTimeoutMillisecond.Text = "1000";
            this.txtTimeoutMillisecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTaskTimeout
            // 
            this.btnTaskTimeout.Location = new System.Drawing.Point(25, 69);
            this.btnTaskTimeout.Name = "btnTaskTimeout";
            this.btnTaskTimeout.Size = new System.Drawing.Size(141, 23);
            this.btnTaskTimeout.TabIndex = 12;
            this.btnTaskTimeout.Text = "Task Timeout";
            this.btnTaskTimeout.UseVisualStyleBackColor = true;
            this.btnTaskTimeout.Click += new System.EventHandler(this.btnTaskTimeout_Click);
            // 
            // CancellationDueToTimeout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 207);
            this.Controls.Add(this.btnTaskTimeout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaskMillisecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimeoutMillisecond);
            this.Name = "CancellationDueToTimeout";
            this.Text = "CancellationDueToTimeout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaskMillisecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeoutMillisecond;
        private System.Windows.Forms.Button btnTaskTimeout;
    }
}