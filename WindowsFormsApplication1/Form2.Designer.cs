namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.labelPontuacao = new System.Windows.Forms.Label();
            this.buttonJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPontuacao
            // 
            this.labelPontuacao.AutoSize = true;
            this.labelPontuacao.Location = new System.Drawing.Point(12, 18);
            this.labelPontuacao.Name = "labelPontuacao";
            this.labelPontuacao.Size = new System.Drawing.Size(0, 13);
            this.labelPontuacao.TabIndex = 0;
            // 
            // buttonJogar
            // 
            this.buttonJogar.Location = new System.Drawing.Point(3, 127);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(75, 23);
            this.buttonJogar.TabIndex = 1;
            this.buttonJogar.Text = "Jogar";
            this.buttonJogar.UseVisualStyleBackColor = true;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 162);
            this.Controls.Add(this.buttonJogar);
            this.Controls.Add(this.labelPontuacao);
            this.Name = "Form2";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPontuacao;
        private System.Windows.Forms.Button buttonJogar;
    }
}