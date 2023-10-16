namespace Projeto_Calculando
{
    partial class Nivel
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
            this.FacilButton = new System.Windows.Forms.Button();
            this.niveislbl = new System.Windows.Forms.Label();
            this.MedioButton = new System.Windows.Forms.Button();
            this.DificilButton = new System.Windows.Forms.Button();
            this.VoltarNiveislbl = new System.Windows.Forms.Label();
            this.VoltarButtonNiveis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FacilButton
            // 
            this.FacilButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FacilButton.BackColor = System.Drawing.Color.Gold;
            this.FacilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FacilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacilButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.FacilButton.Location = new System.Drawing.Point(242, 159);
            this.FacilButton.Name = "FacilButton";
            this.FacilButton.Size = new System.Drawing.Size(300, 50);
            this.FacilButton.TabIndex = 11;
            this.FacilButton.Text = "Fácil";
            this.FacilButton.UseVisualStyleBackColor = false;
            this.FacilButton.MouseEnter += new System.EventHandler(this.MudaCor_FacilButton);
            this.FacilButton.MouseLeave += new System.EventHandler(this.VoltaCor_FacilButton);
            // 
            // niveislbl
            // 
            this.niveislbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.niveislbl.BackColor = System.Drawing.Color.Transparent;
            this.niveislbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.niveislbl.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveislbl.ForeColor = System.Drawing.Color.Gold;
            this.niveislbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.niveislbl.Location = new System.Drawing.Point(184, 18);
            this.niveislbl.Name = "niveislbl";
            this.niveislbl.Size = new System.Drawing.Size(440, 80);
            this.niveislbl.TabIndex = 10;
            this.niveislbl.Text = "Níveis";
            this.niveislbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedioButton
            // 
            this.MedioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MedioButton.BackColor = System.Drawing.Color.Gold;
            this.MedioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MedioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedioButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedioButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.MedioButton.Location = new System.Drawing.Point(242, 236);
            this.MedioButton.Name = "MedioButton";
            this.MedioButton.Size = new System.Drawing.Size(300, 50);
            this.MedioButton.TabIndex = 12;
            this.MedioButton.Text = "Médio";
            this.MedioButton.UseVisualStyleBackColor = false;
            this.MedioButton.MouseEnter += new System.EventHandler(this.MudaCor_MedioButton);
            this.MedioButton.MouseLeave += new System.EventHandler(this.VoltaCor_MedioButton);
            // 
            // DificilButton
            // 
            this.DificilButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DificilButton.BackColor = System.Drawing.Color.Gold;
            this.DificilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DificilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DificilButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DificilButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.DificilButton.Location = new System.Drawing.Point(242, 316);
            this.DificilButton.Name = "DificilButton";
            this.DificilButton.Size = new System.Drawing.Size(300, 50);
            this.DificilButton.TabIndex = 13;
            this.DificilButton.Text = "Difícil";
            this.DificilButton.UseVisualStyleBackColor = false;
            this.DificilButton.MouseEnter += new System.EventHandler(this.MudaCor_DificilButton);
            this.DificilButton.MouseLeave += new System.EventHandler(this.VoltaCor_DificilButton);
            // 
            // VoltarNiveislbl
            // 
            this.VoltarNiveislbl.AutoSize = true;
            this.VoltarNiveislbl.BackColor = System.Drawing.Color.Transparent;
            this.VoltarNiveislbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.VoltarNiveislbl.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoltarNiveislbl.ForeColor = System.Drawing.Color.Gold;
            this.VoltarNiveislbl.Location = new System.Drawing.Point(19, 76);
            this.VoltarNiveislbl.Name = "VoltarNiveislbl";
            this.VoltarNiveislbl.Size = new System.Drawing.Size(84, 23);
            this.VoltarNiveislbl.TabIndex = 15;
            this.VoltarNiveislbl.Text = "Voltar";
            // 
            // VoltarButtonNiveis
            // 
            this.VoltarButtonNiveis.BackgroundImage = global::Projeto_Calculando.Properties.Resources.Voltar;
            this.VoltarButtonNiveis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VoltarButtonNiveis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VoltarButtonNiveis.Location = new System.Drawing.Point(23, 28);
            this.VoltarButtonNiveis.Name = "VoltarButtonNiveis";
            this.VoltarButtonNiveis.Size = new System.Drawing.Size(80, 42);
            this.VoltarButtonNiveis.TabIndex = 14;
            this.VoltarButtonNiveis.UseVisualStyleBackColor = true;
            this.VoltarButtonNiveis.Click += new System.EventHandler(this.VoltarButtonNiveis_Click);
            this.VoltarButtonNiveis.MouseEnter += new System.EventHandler(this.MudaCor_VoltarNiveislbl);
            this.VoltarButtonNiveis.MouseLeave += new System.EventHandler(this.VoltaCor_VoltarNiveislbl);
            // 
            // Nivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Calculando.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VoltarNiveislbl);
            this.Controls.Add(this.VoltarButtonNiveis);
            this.Controls.Add(this.DificilButton);
            this.Controls.Add(this.MedioButton);
            this.Controls.Add(this.FacilButton);
            this.Controls.Add(this.niveislbl);
            this.Name = "Nivel";
            this.Text = "Nivel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FacilButton;
        private System.Windows.Forms.Label niveislbl;
        private System.Windows.Forms.Button MedioButton;
        private System.Windows.Forms.Button DificilButton;
        private System.Windows.Forms.Label VoltarNiveislbl;
        private System.Windows.Forms.Button VoltarButtonNiveis;
    }
}