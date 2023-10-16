namespace Projeto_Calculando
{
    partial class Operacoes
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
            this.VoltarButton = new System.Windows.Forms.Button();
            this.Operacaolbl = new System.Windows.Forms.Label();
            this.DivisaoButton = new System.Windows.Forms.Button();
            this.MultiplicacaoButton = new System.Windows.Forms.Button();
            this.SubtracaoButton = new System.Windows.Forms.Button();
            this.AdicaoButton = new System.Windows.Forms.Button();
            this.Voltarlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VoltarButton
            // 
            this.VoltarButton.BackgroundImage = global::Projeto_Calculando.Properties.Resources.Voltar;
            this.VoltarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VoltarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VoltarButton.Location = new System.Drawing.Point(35, 27);
            this.VoltarButton.Name = "VoltarButton";
            this.VoltarButton.Size = new System.Drawing.Size(80, 42);
            this.VoltarButton.TabIndex = 11;
            this.VoltarButton.UseVisualStyleBackColor = true;
            this.VoltarButton.Click += new System.EventHandler(this.VoltarButton_Click);
            this.VoltarButton.MouseEnter += new System.EventHandler(this.MudaCor_VoltarOperacoes);
            this.VoltarButton.MouseLeave += new System.EventHandler(this.VoltaCor_VoltarOperacoes);
            // 
            // Operacaolbl
            // 
            this.Operacaolbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Operacaolbl.BackColor = System.Drawing.Color.Transparent;
            this.Operacaolbl.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operacaolbl.ForeColor = System.Drawing.Color.Gold;
            this.Operacaolbl.Location = new System.Drawing.Point(183, 9);
            this.Operacaolbl.Name = "Operacaolbl";
            this.Operacaolbl.Size = new System.Drawing.Size(440, 80);
            this.Operacaolbl.TabIndex = 10;
            this.Operacaolbl.Text = "Operação";
            this.Operacaolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivisaoButton
            // 
            this.DivisaoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisaoButton.BackColor = System.Drawing.Color.Gold;
            this.DivisaoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivisaoButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisaoButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.DivisaoButton.Location = new System.Drawing.Point(301, 316);
            this.DivisaoButton.Name = "DivisaoButton";
            this.DivisaoButton.Size = new System.Drawing.Size(200, 50);
            this.DivisaoButton.TabIndex = 9;
            this.DivisaoButton.Text = "DIVISÃO";
            this.DivisaoButton.UseVisualStyleBackColor = false;
            this.DivisaoButton.MouseEnter += new System.EventHandler(this.MudaCor_Divisao);
            this.DivisaoButton.MouseLeave += new System.EventHandler(this.VoltaCor_Divisao);
            // 
            // MultiplicacaoButton
            // 
            this.MultiplicacaoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiplicacaoButton.BackColor = System.Drawing.Color.Gold;
            this.MultiplicacaoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultiplicacaoButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicacaoButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.MultiplicacaoButton.Location = new System.Drawing.Point(301, 249);
            this.MultiplicacaoButton.Name = "MultiplicacaoButton";
            this.MultiplicacaoButton.Size = new System.Drawing.Size(200, 50);
            this.MultiplicacaoButton.TabIndex = 8;
            this.MultiplicacaoButton.Text = "MULTIPLICAÇÃO";
            this.MultiplicacaoButton.UseVisualStyleBackColor = false;
            this.MultiplicacaoButton.MouseEnter += new System.EventHandler(this.MudaCor_Multiplicacao);
            this.MultiplicacaoButton.MouseLeave += new System.EventHandler(this.VoltaCor_Multiplicacao);
            // 
            // SubtracaoButton
            // 
            this.SubtracaoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtracaoButton.BackColor = System.Drawing.Color.Gold;
            this.SubtracaoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubtracaoButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtracaoButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.SubtracaoButton.Location = new System.Drawing.Point(301, 183);
            this.SubtracaoButton.Name = "SubtracaoButton";
            this.SubtracaoButton.Size = new System.Drawing.Size(200, 50);
            this.SubtracaoButton.TabIndex = 7;
            this.SubtracaoButton.Text = "SUBTRAÇÃO";
            this.SubtracaoButton.UseVisualStyleBackColor = false;
            this.SubtracaoButton.MouseEnter += new System.EventHandler(this.MudaCor_Subtracao);
            this.SubtracaoButton.MouseLeave += new System.EventHandler(this.VoltaCor_Subtracao);
            // 
            // AdicaoButton
            // 
            this.AdicaoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdicaoButton.BackColor = System.Drawing.Color.Gold;
            this.AdicaoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdicaoButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicaoButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.AdicaoButton.Location = new System.Drawing.Point(301, 116);
            this.AdicaoButton.Name = "AdicaoButton";
            this.AdicaoButton.Size = new System.Drawing.Size(200, 50);
            this.AdicaoButton.TabIndex = 6;
            this.AdicaoButton.Text = "ADIÇÃO";
            this.AdicaoButton.UseVisualStyleBackColor = false;
            this.AdicaoButton.Click += new System.EventHandler(this.AdicaoButton_Click);
            this.AdicaoButton.MouseEnter += new System.EventHandler(this.MudaCor_Adicao);
            this.AdicaoButton.MouseLeave += new System.EventHandler(this.VoltaCor_Adicao);
            // 
            // Voltarlbl
            // 
            this.Voltarlbl.AutoSize = true;
            this.Voltarlbl.BackColor = System.Drawing.Color.Transparent;
            this.Voltarlbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Voltarlbl.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltarlbl.ForeColor = System.Drawing.Color.Gold;
            this.Voltarlbl.Location = new System.Drawing.Point(31, 72);
            this.Voltarlbl.Name = "Voltarlbl";
            this.Voltarlbl.Size = new System.Drawing.Size(84, 23);
            this.Voltarlbl.TabIndex = 12;
            this.Voltarlbl.Text = "Voltar";
            // 
            // Operacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Calculando.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltarlbl);
            this.Controls.Add(this.VoltarButton);
            this.Controls.Add(this.Operacaolbl);
            this.Controls.Add(this.DivisaoButton);
            this.Controls.Add(this.MultiplicacaoButton);
            this.Controls.Add(this.SubtracaoButton);
            this.Controls.Add(this.AdicaoButton);
            this.Name = "Operacoes";
            this.Text = "Operacoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VoltarButton;
        private System.Windows.Forms.Label Operacaolbl;
        private System.Windows.Forms.Button DivisaoButton;
        private System.Windows.Forms.Button MultiplicacaoButton;
        private System.Windows.Forms.Button SubtracaoButton;
        private System.Windows.Forms.Button AdicaoButton;
        private System.Windows.Forms.Label Voltarlbl;
    }
}