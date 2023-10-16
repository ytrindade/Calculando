using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculando
{
    public partial class Operacoes : Form
    {
        public Operacoes()
        {
            InitializeComponent();
        }

        //Abrir e fechar janela
        Thread t2;
        Thread t3;

        //Volta para a tela inicial ao ser clicado
        private void VoltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(VoltarParaTelaInicial);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void VoltarParaTelaInicial(object obj)
        {
            Application.Run(new TelaInicial());
        }
        //


        //Vai para Adições ao ser clicado
        private void AdicaoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(AbrirNivel);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        private void AbrirNivel(object obj)
        {
            Application.Run(new Nivel());
        }
        //
        //Fim abrir e fechar janela




        //Muda Cor ao passar o mouse
        private void MudaCor_Adicao(object sender, EventArgs e)
        {
            AdicaoButton.ForeColor = Color.White;
        }

        private void VoltaCor_Adicao(object sender, EventArgs e)
        {
            AdicaoButton.ForeColor = Color.DarkOrange;
        }

        private void MudaCor_Subtracao(object sender, EventArgs e)
        {
            SubtracaoButton.ForeColor = Color.White;
        }

        private void VoltaCor_Subtracao(object sender, EventArgs e)
        {
            SubtracaoButton.ForeColor = Color.DarkOrange;
        }

        private void MudaCor_Multiplicacao(object sender, EventArgs e)
        {
            MultiplicacaoButton.ForeColor = Color.White;
        }

        private void VoltaCor_Multiplicacao(object sender, EventArgs e)
        {
            MultiplicacaoButton.ForeColor = Color.DarkOrange;
        }

        private void MudaCor_Divisao(object sender, EventArgs e)
        {
            DivisaoButton.ForeColor = Color.White;
        }

        private void VoltaCor_Divisao(object sender, EventArgs e)
        {
            DivisaoButton.ForeColor = Color.DarkOrange;
        }

        private void MudaCor_VoltarOperacoes(object sender, EventArgs e)
        {
            Voltarlbl.ForeColor = Color.White;
        }

        private void VoltaCor_VoltarOperacoes(object sender, EventArgs e)
        {
            Voltarlbl.ForeColor = Color.Gold;
        }
        //Muda Cor ao passar o mouse

    }
}
