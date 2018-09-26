namespace DatabaseManager
{
    partial class Constraint
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbChildT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbParentT = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Child table";
            // 
            // tbChildT
            // 
            this.tbChildT.Location = new System.Drawing.Point(199, 46);
            this.tbChildT.Name = "tbChildT";
            this.tbChildT.Size = new System.Drawing.Size(161, 22);
            this.tbChildT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre constraint";
            // 
            // tbNameC
            // 
            this.tbNameC.Location = new System.Drawing.Point(199, 87);
            this.tbNameC.Name = "tbNameC";
            this.tbNameC.Size = new System.Drawing.Size(161, 22);
            this.tbNameC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parent table";
            // 
            // tbParentT
            // 
            this.tbParentT.Location = new System.Drawing.Point(199, 126);
            this.tbParentT.Name = "tbParentT";
            this.tbParentT.Size = new System.Drawing.Size(161, 22);
            this.tbParentT.TabIndex = 6;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(161, 169);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 7;
            this.bCreate.Text = "Crear";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // Constraint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 217);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tbParentT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNameC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbChildT);
            this.Controls.Add(this.label1);
            this.Name = "Constraint";
            this.Text = "Constraint";
            this.Load += new System.EventHandler(this.Constraint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChildT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbParentT;
        private System.Windows.Forms.Button bCreate;
    }
}