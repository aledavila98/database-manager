namespace DatabaseManager
{
    partial class Procedimientos
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
            this.bListar = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(393, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(466, 38);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(169, 34);
            this.bListar.TabIndex = 1;
            this.bListar.Text = "Listar procedimientos";
            this.bListar.UseVisualStyleBackColor = true;
            this.bListar.Click += new System.EventHandler(this.bListar_Click);
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(466, 97);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(169, 34);
            this.bCrear.TabIndex = 2;
            this.bCrear.Text = "Crear procedimiento";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(466, 155);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(169, 34);
            this.bModificar.TabIndex = 3;
            this.bModificar.Text = "Modificar procedimiento";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(466, 214);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(169, 34);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.Text = "Eliminar procedimiento";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Procedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.bListar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Procedimientos";
            this.Text = "Procedimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button button1;
    }
}