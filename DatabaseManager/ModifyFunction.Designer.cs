namespace DatabaseManager
{
    partial class ModifyFunction
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
            this.tbModifyFunction = new System.Windows.Forms.RichTextBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbParams = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReturn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbModifyFunction
            // 
            this.tbModifyFunction.Location = new System.Drawing.Point(56, 273);
            this.tbModifyFunction.Name = "tbModifyFunction";
            this.tbModifyFunction.Size = new System.Drawing.Size(454, 120);
            this.tbModifyFunction.TabIndex = 0;
            this.tbModifyFunction.Text = "";
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(190, 426);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(171, 34);
            this.bSubmit.TabIndex = 1;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parametros";
            // 
            // tbParams
            // 
            this.tbParams.Location = new System.Drawing.Point(201, 41);
            this.tbParams.Name = "tbParams";
            this.tbParams.Size = new System.Drawing.Size(309, 96);
            this.tbParams.TabIndex = 4;
            this.tbParams.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de retorno";
            // 
            // tbReturn
            // 
            this.tbReturn.Location = new System.Drawing.Point(201, 182);
            this.tbReturn.Name = "tbReturn";
            this.tbReturn.Size = new System.Drawing.Size(309, 22);
            this.tbReturn.TabIndex = 6;
            // 
            // ModifyFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 507);
            this.Controls.Add(this.tbReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbParams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.tbModifyFunction);
            this.Name = "ModifyFunction";
            this.Text = "ModifyFunction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbModifyFunction;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbParams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReturn;
    }
}