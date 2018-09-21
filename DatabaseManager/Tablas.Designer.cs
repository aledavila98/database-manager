namespace DatabaseManager
{
    partial class Tablas
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
            this.bListar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bCrearTabla = new System.Windows.Forms.Button();
            this.bAdminTablas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(458, 46);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(161, 34);
            this.bListar.TabIndex = 0;
            this.bListar.Text = "Listar Tablas";
            this.bListar.UseVisualStyleBackColor = true;
            this.bListar.Click += new System.EventHandler(this.bListar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(351, 341);
            this.dataGridView1.TabIndex = 1;
            // 
            // bCrearTabla
            // 
            this.bCrearTabla.Location = new System.Drawing.Point(458, 109);
            this.bCrearTabla.Name = "bCrearTabla";
            this.bCrearTabla.Size = new System.Drawing.Size(161, 34);
            this.bCrearTabla.TabIndex = 2;
            this.bCrearTabla.Text = "Crear Tabla";
            this.bCrearTabla.UseVisualStyleBackColor = true;
            this.bCrearTabla.Click += new System.EventHandler(this.bCrearTabla_Click);
            // 
            // bAdminTablas
            // 
            this.bAdminTablas.Location = new System.Drawing.Point(458, 169);
            this.bAdminTablas.Name = "bAdminTablas";
            this.bAdminTablas.Size = new System.Drawing.Size(161, 34);
            this.bAdminTablas.TabIndex = 3;
            this.bAdminTablas.Text = "Administrar tablas";
            this.bAdminTablas.UseVisualStyleBackColor = true;
            this.bAdminTablas.Click += new System.EventHandler(this.bAdminTablas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bAdminTablas);
            this.Controls.Add(this.bCrearTabla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bListar);
            this.Name = "Tablas";
            this.Text = "Tablas";
            this.Load += new System.EventHandler(this.Tablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bCrearTabla;
        private System.Windows.Forms.Button bAdminTablas;
        private System.Windows.Forms.Button button1;
    }
}