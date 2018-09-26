namespace DatabaseManager
{
    partial class CreateTrigger
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTiempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCrud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFuncion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTabla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(227, 61);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(164, 22);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo de ejecucion";
            // 
            // tbTiempo
            // 
            this.tbTiempo.Location = new System.Drawing.Point(227, 108);
            this.tbTiempo.Name = "tbTiempo";
            this.tbTiempo.Size = new System.Drawing.Size(164, 22);
            this.tbTiempo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de proceso";
            // 
            // tbCrud
            // 
            this.tbCrud.Location = new System.Drawing.Point(227, 157);
            this.tbCrud.Name = "tbCrud";
            this.tbCrud.Size = new System.Drawing.Size(164, 22);
            this.tbCrud.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Funcion";
            // 
            // tbFuncion
            // 
            this.tbFuncion.Location = new System.Drawing.Point(227, 240);
            this.tbFuncion.Name = "tbFuncion";
            this.tbFuncion.Size = new System.Drawing.Size(164, 22);
            this.tbFuncion.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tabla";
            // 
            // tbTabla
            // 
            this.tbTabla.Location = new System.Drawing.Point(227, 200);
            this.tbTabla.Name = "tbTabla";
            this.tbTabla.Size = new System.Drawing.Size(164, 22);
            this.tbTabla.TabIndex = 10;
            // 
            // CreateTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 365);
            this.Controls.Add(this.tbTabla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFuncion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCrud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "CreateTrigger";
            this.Text = "CreateTrigger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCrud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFuncion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTabla;
    }
}