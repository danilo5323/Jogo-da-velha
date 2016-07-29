namespace WindowsFormsApplication1
{
    partial class Inicio
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
            this.radioButtonO = new System.Windows.Forms.RadioButton();
            this.radioButtonX = new System.Windows.Forms.RadioButton();
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
            this.buttonJogar.Location = new System.Drawing.Point(65, 84);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(75, 23);
            this.buttonJogar.TabIndex = 1;
            this.buttonJogar.Text = "Jogar";
            this.buttonJogar.UseVisualStyleBackColor = true;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // radioButtonO
            // 
            this.radioButtonO.AutoSize = true;
            this.radioButtonO.Location = new System.Drawing.Point(65, 18);
            this.radioButtonO.Name = "radioButtonO";
            this.radioButtonO.Size = new System.Drawing.Size(33, 17);
            this.radioButtonO.TabIndex = 2;
            this.radioButtonO.TabStop = true;
            this.radioButtonO.Text = "O";
            this.radioButtonO.UseVisualStyleBackColor = true;
            this.radioButtonO.CheckedChanged += new System.EventHandler(this.radioButtonO_CheckedChanged);
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.Location = new System.Drawing.Point(113, 18);
            this.radioButtonX.Name = "radioButtonX";
            this.radioButtonX.Size = new System.Drawing.Size(32, 17);
            this.radioButtonX.TabIndex = 3;
            this.radioButtonX.TabStop = true;
            this.radioButtonX.Text = "X";
            this.radioButtonX.UseVisualStyleBackColor = true;
            this.radioButtonX.CheckedChanged += new System.EventHandler(this.radioButtonX_CheckedChanged);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 130);
            this.Controls.Add(this.radioButtonX);
            this.Controls.Add(this.radioButtonO);
            this.Controls.Add(this.buttonJogar);
            this.Controls.Add(this.labelPontuacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Inicio";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPontuacao;
        private System.Windows.Forms.Button buttonJogar;
        private System.Windows.Forms.RadioButton radioButtonO;
        private System.Windows.Forms.RadioButton radioButtonX;
    }
}