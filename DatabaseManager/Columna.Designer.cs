namespace DatabaseManager
{
    partial class Columna
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bAñadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre columna";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(175, 41);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(154, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(363, 47);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(36, 17);
            this.Tipo.TabIndex = 2;
            this.Tipo.Text = "Tipo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(431, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 3;
            // 
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(237, 83);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(107, 32);
            this.bAñadir.TabIndex = 4;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // Columna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 127);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "Columna";
            this.Text = "Columna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bAñadir;
    }
}