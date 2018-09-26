namespace DatabaseManager
{
    partial class Views
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
            this.bList = new System.Windows.Forms.Button();
            this.bViews = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(321, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // bList
            // 
            this.bList.Location = new System.Drawing.Point(418, 41);
            this.bList.Name = "bList";
            this.bList.Size = new System.Drawing.Size(131, 32);
            this.bList.TabIndex = 1;
            this.bList.Text = "Listar views";
            this.bList.UseVisualStyleBackColor = true;
            this.bList.Click += new System.EventHandler(this.bList_Click);
            // 
            // bViews
            // 
            this.bViews.Location = new System.Drawing.Point(418, 104);
            this.bViews.Name = "bViews";
            this.bViews.Size = new System.Drawing.Size(131, 32);
            this.bViews.TabIndex = 2;
            this.bViews.Text = "Crear Views";
            this.bViews.UseVisualStyleBackColor = true;
            this.bViews.Click += new System.EventHandler(this.bViews_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(418, 170);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(131, 32);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Borrar view";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.Location = new System.Drawing.Point(418, 346);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(131, 32);
            this.bRegresar.TabIndex = 4;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = true;
            // 
            // Views
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 436);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bViews);
            this.Controls.Add(this.bList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Views";
            this.Text = "Views";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bList;
        private System.Windows.Forms.Button bViews;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bRegresar;
    }
}