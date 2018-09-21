namespace DatabaseManager
{
    partial class VerDDL
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
            this.tbFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(53, 49);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(515, 407);
            this.tbFile.TabIndex = 0;
            this.tbFile.Text = "";
            // 
            // VerDDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 565);
            this.Controls.Add(this.tbFile);
            this.Name = "VerDDL";
            this.Text = "VerDDL";
            this.Load += new System.EventHandler(this.VerDDL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbFile;
    }
}