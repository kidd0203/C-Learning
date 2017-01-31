namespace AsyncProgramming
{
    partial class PauseAsync
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaskTimeout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeoutMillisecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaskMillisecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "PauseForCertainSeconds";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(99, 16);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(62, 20);
            this.txtSeconds.TabIndex = 1;
            this.txtSeconds.Text = "1000";
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MilliSeconds:";
            // 
            // btnTaskTimeout
            // 
            this.btnTaskTimeout.Location = new System.Drawing.Point(22, 151);
            this.btnTaskTimeout.Name = "btnTaskTimeout";
            this.btnTaskTimeout.Size = new System.Drawing.Size(141, 23);
            this.btnTaskTimeout.TabIndex = 3;
            this.btnTaskTimeout.Text = "Task Timeout";
            this.btnTaskTimeout.UseVisualStyleBackColor = true;
            this.btnTaskTimeout.Click += new System.EventHandler(this.btnTaskTimeout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timeout:";
            // 
            // txtTimeoutMillisecond
            // 
            this.txtTimeoutMillisecond.Location = new System.Drawing.Point(99, 102);
            this.txtTimeoutMillisecond.Name = "txtTimeoutMillisecond";
            this.txtTimeoutMillisecond.Size = new System.Drawing.Size(62, 20);
            this.txtTimeoutMillisecond.TabIndex = 4;
            this.txtTimeoutMillisecond.Text = "1000";
            this.txtTimeoutMillisecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Task:";
            // 
            // txtTaskMillisecond
            // 
            this.txtTaskMillisecond.Location = new System.Drawing.Point(99, 124);
            this.txtTaskMillisecond.Name = "txtTaskMillisecond";
            this.txtTaskMillisecond.Size = new System.Drawing.Size(62, 20);
            this.txtTaskMillisecond.TabIndex = 6;
            this.txtTaskMillisecond.Text = "2000";
            this.txtTaskMillisecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PauseAsync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaskMillisecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimeoutMillisecond);
            this.Controls.Add(this.btnTaskTimeout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.button1);
            this.Name = "PauseAsync";
            this.Text = "PauseAsync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaskTimeout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeoutMillisecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaskMillisecond;
    }
}