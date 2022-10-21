namespace AppModelo.View.Windows
{
    partial class frmStart
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
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnNacionalidade = new System.Windows.Forms.Button();
            this.btnNaturalidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Location = new System.Drawing.Point(31, 49);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(192, 23);
            this.btnFuncionarios.TabIndex = 0;
            this.btnFuncionarios.Text = "FUNCIONARIOS";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnNacionalidade
            // 
            this.btnNacionalidade.Location = new System.Drawing.Point(31, 87);
            this.btnNacionalidade.Name = "btnNacionalidade";
            this.btnNacionalidade.Size = new System.Drawing.Size(192, 23);
            this.btnNacionalidade.TabIndex = 1;
            this.btnNacionalidade.Text = "NACIONALIDADE";
            this.btnNacionalidade.UseVisualStyleBackColor = true;
            this.btnNacionalidade.Click += new System.EventHandler(this.btnNacionalidade_Click);
            // 
            // btnNaturalidade
            // 
            this.btnNaturalidade.Location = new System.Drawing.Point(31, 130);
            this.btnNaturalidade.Name = "btnNaturalidade";
            this.btnNaturalidade.Size = new System.Drawing.Size(192, 23);
            this.btnNaturalidade.TabIndex = 2;
            this.btnNaturalidade.Text = "NATURALIDADE";
            this.btnNaturalidade.UseVisualStyleBackColor = true;
            this.btnNaturalidade.Click += new System.EventHandler(this.btnNaturalidade_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 218);
            this.Controls.Add(this.btnNaturalidade);
            this.Controls.Add(this.btnNacionalidade);
            this.Controls.Add(this.btnFuncionarios);
            this.Name = "frmStart";
            this.Text = "frmStart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnNacionalidade;
        private System.Windows.Forms.Button btnNaturalidade;
    }
}