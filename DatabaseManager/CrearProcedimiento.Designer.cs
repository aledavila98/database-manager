namespace DatabaseManager
{
    partial class CrearProcedimiento
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
            this.tbNombreP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbParametros = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTipoRetorno = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.RichTextBox();
            this.bCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de procedimiento";
            // 
            // tbNombreP
            // 
            this.tbNombreP.Location = new System.Drawing.Point(240, 28);
            this.tbNombreP.Name = "tbNombreP";
            this.tbNombreP.Size = new System.Drawing.Size(210, 22);
            this.tbNombreP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parametros";
            // 
            // tbParametros
            // 
            this.tbParametros.Location = new System.Drawing.Point(240, 67);
            this.tbParametros.Name = "tbParametros";
            this.tbParametros.Size = new System.Drawing.Size(210, 102);
            this.tbParametros.TabIndex = 3;
            this.tbParametros.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de retorno";
            // 
            // tbTipoRetorno
            // 
            this.tbTipoRetorno.Location = new System.Drawing.Point(240, 180);
            this.tbTipoRetorno.Name = "tbTipoRetorno";
            this.tbTipoRetorno.Size = new System.Drawing.Size(210, 22);
            this.tbTipoRetorno.TabIndex = 5;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(211, 234);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(52, 17);
            this.labelC.TabIndex = 6;
            this.labelC.Text = "Codigo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(41, 273);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(409, 170);
            this.tbCodigo.TabIndex = 7;
            this.tbCodigo.Text = "";
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(162, 472);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(153, 23);
            this.bCrear.TabIndex = 8;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // CrearProcedimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 520);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.tbTipoRetorno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbParametros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreP);
            this.Controls.Add(this.label1);
            this.Name = "CrearProcedimiento";
            this.Text = "CrearProcedimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbParametros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTipoRetorno;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.RichTextBox tbCodigo;
        private System.Windows.Forms.Button bCrear;
    }
}