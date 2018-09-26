namespace DatabaseManager
{
    partial class Triggers
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(48, 422);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(133, 28);
            this.bListar.TabIndex = 1;
            this.bListar.Text = "Listar";
            this.bListar.UseVisualStyleBackColor = true;
            this.bListar.Click += new System.EventHandler(this.bListar_Click);
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(202, 422);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(133, 28);
            this.bCrear.TabIndex = 2;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(356, 422);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(133, 28);
            this.bModificar.TabIndex = 3;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Triggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.bListar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Triggers";
            this.Text = "Triggers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button button1;
    }
}