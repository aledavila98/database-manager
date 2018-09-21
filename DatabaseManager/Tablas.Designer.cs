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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(73, 397);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(161, 34);
            this.bListar.TabIndex = 0;
            this.bListar.Text = "Listar Tablas";
            this.bListar.UseVisualStyleBackColor = true;
            this.bListar.Click += new System.EventHandler(this.bListar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 308);
            this.dataGridView1.TabIndex = 1;
            // 
            // bCrearTabla
            // 
            this.bCrearTabla.Location = new System.Drawing.Point(276, 397);
            this.bCrearTabla.Name = "bCrearTabla";
            this.bCrearTabla.Size = new System.Drawing.Size(148, 34);
            this.bCrearTabla.TabIndex = 2;
            this.bCrearTabla.Text = "Crear Tabla";
            this.bCrearTabla.UseVisualStyleBackColor = true;
            this.bCrearTabla.Click += new System.EventHandler(this.bCrearTabla_Click);
            // 
            // Tablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 465);
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
    }
}