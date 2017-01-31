namespace AsyncProgramming
{
    partial class ReturningCompletedTask
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
            this.btnRtnValue = new System.Windows.Forms.Button();
            this.btnRtnException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRtnValue
            // 
            this.btnRtnValue.Location = new System.Drawing.Point(51, 59);
            this.btnRtnValue.Name = "btnRtnValue";
            this.btnRtnValue.Size = new System.Drawing.Size(109, 23);
            this.btnRtnValue.TabIndex = 0;
            this.btnRtnValue.Text = "ReturnValue";
            this.btnRtnValue.UseVisualStyleBackColor = true;
            this.btnRtnValue.Click += new System.EventHandler(this.btnRtnValue_Click);
            // 
            // btnRtnException
            // 
            this.btnRtnException.Location = new System.Drawing.Point(51, 98);
            this.btnRtnException.Name = "btnRtnException";
            this.btnRtnException.Size = new System.Drawing.Size(109, 23);
            this.btnRtnException.TabIndex = 1;
            this.btnRtnException.Text = "ReturnException";
            this.btnRtnException.UseVisualStyleBackColor = true;
            this.btnRtnException.Click += new System.EventHandler(this.btnRtnException_Click);
            // 
            // ReturningCompletedTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRtnException);
            this.Controls.Add(this.btnRtnValue);
            this.Name = "ReturningCompletedTask";
            this.Text = "ReturningCompletedTask";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRtnValue;
        private System.Windows.Forms.Button btnRtnException;
    }
}