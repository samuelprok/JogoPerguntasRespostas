﻿namespace JogoDesktop
{
    partial class Pergunta1
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
            this.lblPergunta = new System.Windows.Forms.Label();
            this.rdbResposta1 = new System.Windows.Forms.RadioButton();
            this.rdbResposta2 = new System.Windows.Forms.RadioButton();
            this.rdbResposta3 = new System.Windows.Forms.RadioButton();
            this.rdbResposta4 = new System.Windows.Forms.RadioButton();
            this.btnProxima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(63, 46);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(262, 13);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "1) O software tem por objetivo em uma apresentação?";
            this.lblPergunta.Click += new System.EventHandler(this.lblPergunta_Click);
            // 
            // rdbResposta1
            // 
            this.rdbResposta1.AutoSize = true;
            this.rdbResposta1.Location = new System.Drawing.Point(66, 115);
            this.rdbResposta1.Name = "rdbResposta1";
            this.rdbResposta1.Size = new System.Drawing.Size(231, 17);
            this.rdbResposta1.TabIndex = 1;
            this.rdbResposta1.TabStop = true;
            this.rdbResposta1.Text = "O software deve ter muitas funcionalidades.";
            this.rdbResposta1.UseVisualStyleBackColor = true;
            this.rdbResposta1.CheckedChanged += new System.EventHandler(this.rdbResposta1_CheckedChanged);
            // 
            // rdbResposta2
            // 
            this.rdbResposta2.AutoSize = true;
            this.rdbResposta2.Location = new System.Drawing.Point(66, 149);
            this.rdbResposta2.Name = "rdbResposta2";
            this.rdbResposta2.Size = new System.Drawing.Size(236, 17);
            this.rdbResposta2.TabIndex = 2;
            this.rdbResposta2.TabStop = true;
            this.rdbResposta2.Text = "O software deve reproduzir efeitos especiais.";
            this.rdbResposta2.UseVisualStyleBackColor = true;
            this.rdbResposta2.CheckedChanged += new System.EventHandler(this.rdbResposta2_CheckedChanged);
            // 
            // rdbResposta3
            // 
            this.rdbResposta3.AutoSize = true;
            this.rdbResposta3.Location = new System.Drawing.Point(66, 183);
            this.rdbResposta3.Name = "rdbResposta3";
            this.rdbResposta3.Size = new System.Drawing.Size(254, 17);
            this.rdbResposta3.TabIndex = 3;
            this.rdbResposta3.TabStop = true;
            this.rdbResposta3.Text = "O software deve mudar o foco da apresentação.";
            this.rdbResposta3.UseVisualStyleBackColor = true;
            this.rdbResposta3.CheckedChanged += new System.EventHandler(this.rdbResposta3_CheckedChanged);
            // 
            // rdbResposta4
            // 
            this.rdbResposta4.AutoSize = true;
            this.rdbResposta4.Location = new System.Drawing.Point(66, 219);
            this.rdbResposta4.Name = "rdbResposta4";
            this.rdbResposta4.Size = new System.Drawing.Size(339, 17);
            this.rdbResposta4.TabIndex = 4;
            this.rdbResposta4.TabStop = true;
            this.rdbResposta4.Text = "O software deve simplificar a apresentação em vez de complicá-la.";
            this.rdbResposta4.UseVisualStyleBackColor = true;
            this.rdbResposta4.CheckedChanged += new System.EventHandler(this.rdbResposta4_CheckedChanged);
            // 
            // btnProxima
            // 
            this.btnProxima.Location = new System.Drawing.Point(256, 305);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(143, 45);
            this.btnProxima.TabIndex = 5;
            this.btnProxima.Text = "Próxima pergunta";
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // Pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 386);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.rdbResposta4);
            this.Controls.Add(this.rdbResposta3);
            this.Controls.Add(this.rdbResposta2);
            this.Controls.Add(this.rdbResposta1);
            this.Controls.Add(this.lblPergunta);
            this.Name = "Pergunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.RadioButton rdbResposta1;
        private System.Windows.Forms.RadioButton rdbResposta2;
        private System.Windows.Forms.RadioButton rdbResposta3;
        private System.Windows.Forms.RadioButton rdbResposta4;
        private System.Windows.Forms.Button btnProxima;
    }
}