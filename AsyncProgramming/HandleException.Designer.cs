namespace AsyncProgramming
{
    partial class HandleException
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
            this.btnHandleException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHandleException
            // 
            this.btnHandleException.Location = new System.Drawing.Point(41, 33);
            this.btnHandleException.Name = "btnHandleException";
            this.btnHandleException.Size = new System.Drawing.Size(118, 23);
            this.btnHandleException.TabIndex = 0;
            this.btnHandleException.Text = "HandleException";
            this.btnHandleException.UseVisualStyleBackColor = true;
            this.btnHandleException.Click += new System.EventHandler(this.btnHandleException_Click);
            // 
            // HandleException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 237);
            this.Controls.Add(this.btnHandleException);
            this.Name = "HandleException";
            this.Text = "HandleException";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHandleException;
    }
}