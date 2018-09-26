namespace DatabaseManager
{
    partial class Indices
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
            this.bVerIndex = new System.Windows.Forms.Button();
            this.bRegresar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // bVerIndex
            // 
            this.bVerIndex.Location = new System.Drawing.Point(62, 434);
            this.bVerIndex.Name = "bVerIndex";
            this.bVerIndex.Size = new System.Drawing.Size(101, 26);
            this.bVerIndex.TabIndex = 1;
            this.bVerIndex.Text = "Ver Indices";
            this.bVerIndex.UseVisualStyleBackColor = true;
            this.bVerIndex.Click += new System.EventHandler(this.bVerIndex_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.Location = new System.Drawing.Point(542, 434);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(101, 26);
            this.bRegresar.TabIndex = 2;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = true;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(248, 434);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(202, 26);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar indices y constraints";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(354, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(289, 351);
            this.dataGridView2.TabIndex = 4;
            // 
            // Indices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 488);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.bVerIndex);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Indices";
            this.Text = "Indices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bVerIndex;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}