namespace DatabaseManager
{
    partial class MainMenu
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
            this.bConnections = new System.Windows.Forms.Button();
            this.bTablas = new System.Windows.Forms.Button();
            this.bIndices = new System.Windows.Forms.Button();
            this.bProcedimientos = new System.Windows.Forms.Button();
            this.bUsuarios = new System.Windows.Forms.Button();
            this.bVistas = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bConnections
            // 
            this.bConnections.Location = new System.Drawing.Point(164, 64);
            this.bConnections.Name = "bConnections";
            this.bConnections.Size = new System.Drawing.Size(278, 39);
            this.bConnections.TabIndex = 0;
            this.bConnections.Text = "Conexiones";
            this.bConnections.UseVisualStyleBackColor = true;
            this.bConnections.Click += new System.EventHandler(this.bConnections_Click);
            // 
            // bTablas
            // 
            this.bTablas.Location = new System.Drawing.Point(164, 133);
            this.bTablas.Name = "bTablas";
            this.bTablas.Size = new System.Drawing.Size(278, 39);
            this.bTablas.TabIndex = 1;
            this.bTablas.Text = "Tablas";
            this.bTablas.UseVisualStyleBackColor = true;
            this.bTablas.Click += new System.EventHandler(this.bTablas_Click);
            // 
            // bIndices
            // 
            this.bIndices.Location = new System.Drawing.Point(164, 202);
            this.bIndices.Name = "bIndices";
            this.bIndices.Size = new System.Drawing.Size(278, 39);
            this.bIndices.TabIndex = 2;
            this.bIndices.Text = "Indices";
            this.bIndices.UseVisualStyleBackColor = true;
            // 
            // bProcedimientos
            // 
            this.bProcedimientos.Location = new System.Drawing.Point(164, 270);
            this.bProcedimientos.Name = "bProcedimientos";
            this.bProcedimientos.Size = new System.Drawing.Size(278, 39);
            this.bProcedimientos.TabIndex = 3;
            this.bProcedimientos.Text = "Procedimientos y funciones";
            this.bProcedimientos.UseVisualStyleBackColor = true;
            // 
            // bUsuarios
            // 
            this.bUsuarios.Location = new System.Drawing.Point(164, 338);
            this.bUsuarios.Name = "bUsuarios";
            this.bUsuarios.Size = new System.Drawing.Size(278, 39);
            this.bUsuarios.TabIndex = 4;
            this.bUsuarios.Text = "Usuarios";
            this.bUsuarios.UseVisualStyleBackColor = true;
            // 
            // bVistas
            // 
            this.bVistas.Location = new System.Drawing.Point(164, 408);
            this.bVistas.Name = "bVistas";
            this.bVistas.Size = new System.Drawing.Size(278, 39);
            this.bVistas.TabIndex = 5;
            this.bVistas.Text = "Vistas";
            this.bVistas.UseVisualStyleBackColor = true;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(258, 26);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(46, 17);
            this.lName.TabIndex = 6;
            this.lName.Text = "label1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 501);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.bVistas);
            this.Controls.Add(this.bUsuarios);
            this.Controls.Add(this.bProcedimientos);
            this.Controls.Add(this.bIndices);
            this.Controls.Add(this.bTablas);
            this.Controls.Add(this.bConnections);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConnections;
        private System.Windows.Forms.Button bTablas;
        private System.Windows.Forms.Button bIndices;
        private System.Windows.Forms.Button bProcedimientos;
        private System.Windows.Forms.Button bUsuarios;
        private System.Windows.Forms.Button bVistas;
        private System.Windows.Forms.Label lName;
    }
}