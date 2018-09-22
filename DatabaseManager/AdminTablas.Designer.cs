namespace DatabaseManager
{
    partial class AdminTablas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bVerTabla = new System.Windows.Forms.Button();
            this.tbTabla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bGenerar = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bEliminarTabla = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bBorrarF = new System.Windows.Forms.Button();
            this.bAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(338, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar tabla";
            // 
            // bVerTabla
            // 
            this.bVerTabla.Location = new System.Drawing.Point(432, 126);
            this.bVerTabla.Name = "bVerTabla";
            this.bVerTabla.Size = new System.Drawing.Size(132, 31);
            this.bVerTabla.TabIndex = 2;
            this.bVerTabla.Text = "Ver tabla";
            this.bVerTabla.UseVisualStyleBackColor = true;
            this.bVerTabla.Click += new System.EventHandler(this.bVerTabla_Click);
            // 
            // tbTabla
            // 
            this.tbTabla.Location = new System.Drawing.Point(432, 84);
            this.tbTabla.Name = "tbTabla";
            this.tbTabla.Size = new System.Drawing.Size(132, 22);
            this.tbTabla.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bGenerar
            // 
            this.bGenerar.Location = new System.Drawing.Point(432, 449);
            this.bGenerar.Name = "bGenerar";
            this.bGenerar.Size = new System.Drawing.Size(132, 31);
            this.bGenerar.TabIndex = 5;
            this.bGenerar.Text = "Generar DDL";
            this.bGenerar.UseVisualStyleBackColor = true;
            this.bGenerar.Click += new System.EventHandler(this.bGenerar_Click);
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(432, 498);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(132, 31);
            this.bVer.TabIndex = 6;
            this.bVer.Text = "Ver DDL";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(432, 181);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(132, 31);
            this.bSubmit.TabIndex = 7;
            this.bSubmit.Text = "Insertar";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bEliminarTabla
            // 
            this.bEliminarTabla.Location = new System.Drawing.Point(432, 399);
            this.bEliminarTabla.Name = "bEliminarTabla";
            this.bEliminarTabla.Size = new System.Drawing.Size(132, 31);
            this.bEliminarTabla.TabIndex = 8;
            this.bEliminarTabla.Text = "Eliminar tabla";
            this.bEliminarTabla.UseVisualStyleBackColor = true;
            this.bEliminarTabla.Click += new System.EventHandler(this.bEliminarTabla_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(432, 229);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(132, 31);
            this.bActualizar.TabIndex = 9;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bBorrarF
            // 
            this.bBorrarF.Location = new System.Drawing.Point(432, 281);
            this.bBorrarF.Name = "bBorrarF";
            this.bBorrarF.Size = new System.Drawing.Size(132, 31);
            this.bBorrarF.TabIndex = 10;
            this.bBorrarF.Text = "Borrar";
            this.bBorrarF.UseVisualStyleBackColor = true;
            this.bBorrarF.Click += new System.EventHandler(this.bBorrarF_Click);
            // 
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(432, 331);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(132, 31);
            this.bAñadir.TabIndex = 11;
            this.bAñadir.Text = "Añadir columna";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // AdminTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 634);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.bBorrarF);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bEliminarTabla);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bGenerar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTabla);
            this.Controls.Add(this.bVerTabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminTablas";
            this.Text = "AdminTablas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVerTabla;
        private System.Windows.Forms.TextBox tbTabla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bGenerar;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bEliminarTabla;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bBorrarF;
        private System.Windows.Forms.Button bAñadir;
    }
}