namespace Projeto_Calculando
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.JogarButton = new System.Windows.Forms.Button();
            this.Calculandolbl = new System.Windows.Forms.Label();
            this.SairButton = new System.Windows.Forms.Button();
            this.OpcoesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JogarButton
            // 
            this.JogarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.JogarButton.BackColor = System.Drawing.Color.Gold;
            this.JogarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JogarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JogarButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JogarButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.JogarButton.Location = new System.Drawing.Point(224, 182);
            this.JogarButton.Name = "JogarButton";
            this.JogarButton.Size = new System.Drawing.Size(300, 50);
            this.JogarButton.TabIndex = 9;
            this.JogarButton.Text = "JOGAR";
            this.JogarButton.UseVisualStyleBackColor = false;
            this.JogarButton.Click += new System.EventHandler(this.JogarButton_Click);
            this.JogarButton.MouseEnter += new System.EventHandler(this.MudaCor_Jogar);
            this.JogarButton.MouseLeave += new System.EventHandler(this.VoltaCor_Jogar);
            // 
            // Calculandolbl
            // 
            this.Calculandolbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculandolbl.BackColor = System.Drawing.Color.Transparent;
            this.Calculandolbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculandolbl.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculandolbl.ForeColor = System.Drawing.Color.Gold;
            this.Calculandolbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Calculandolbl.Location = new System.Drawing.Point(161, 57);
            this.Calculandolbl.Name = "Calculandolbl";
            this.Calculandolbl.Size = new System.Drawing.Size(440, 80);
            this.Calculandolbl.TabIndex = 8;
            this.Calculandolbl.Text = "CALCULANDO";
            this.Calculandolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SairButton
            // 
            this.SairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SairButton.BackColor = System.Drawing.Color.Gold;
            this.SairButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.SairButton.Location = new System.Drawing.Point(224, 344);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(300, 50);
            this.SairButton.TabIndex = 7;
            this.SairButton.Text = "SAIR";
            this.SairButton.UseVisualStyleBackColor = false;
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            this.SairButton.MouseEnter += new System.EventHandler(this.MudaCor_Sair);
            this.SairButton.MouseLeave += new System.EventHandler(this.VoltaCor_Sair);
            // 
            // OpcoesButton
            // 
            this.OpcoesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcoesButton.BackColor = System.Drawing.Color.Gold;
            this.OpcoesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcoesButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcoesButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.OpcoesButton.Location = new System.Drawing.Point(224, 265);
            this.OpcoesButton.Name = "OpcoesButton";
            this.OpcoesButton.Size = new System.Drawing.Size(300, 50);
            this.OpcoesButton.TabIndex = 6;
            this.OpcoesButton.Text = "OPÇÕES";
            this.OpcoesButton.UseVisualStyleBackColor = false;
            this.OpcoesButton.Click += new System.EventHandler(this.OpcoesButton_Click);
            this.OpcoesButton.MouseEnter += new System.EventHandler(this.MudaCor_Opcoes);
            this.OpcoesButton.MouseLeave += new System.EventHandler(this.VoltaCor_Opcoes);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Calculando.Properties.Resources.Tela_Inicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.JogarButton);
            this.Controls.Add(this.Calculandolbl);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.OpcoesButton);
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JogarButton;
        private System.Windows.Forms.Label Calculandolbl;
        private System.Windows.Forms.Button SairButton;
        private System.Windows.Forms.Button OpcoesButton;
    }
}

