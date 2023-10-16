using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_Calculando
{
    public partial class TelaInicial : Form
    {

        //Abrir e fechar janela
        Thread t1;
        Thread t2;
        public TelaInicial()
        {
            InitializeComponent();
        }

        //Vai para Operações ao ser clicado
        private void JogarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirOperacoes);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        

        private void abrirOperacoes(object obj)
        {
            Application.Run(new Operacoes());
        }
        //

        //Vai para Opções ao ser clicado
        private void OpcoesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(AbrirOpcoes);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void AbrirOpcoes (object obj)
        {
            Application.Run(new Opcoes());
        } 
        //

        //Botão para sair
        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Fim Abrir e fechar janela



        //Muda Cor ao passar o mouse
        private void MudaCor_Jogar(object sender, EventArgs e)
        {
            JogarButton.ForeColor = Color.White;
        }

        private void VoltaCor_Jogar(object sender, EventArgs e)
        {
            JogarButton.ForeColor= Color.DarkOrange;
        }

        private void MudaCor_Opcoes(object sender, EventArgs e)
        {
            OpcoesButton.ForeColor = Color.White;
        }

        private void VoltaCor_Opcoes(object sender, EventArgs e)
        {
            OpcoesButton.ForeColor = Color.DarkOrange;
        }

        private void MudaCor_Sair(object sender, EventArgs e)
        {
            SairButton.ForeColor = Color.White;
        }

        private void VoltaCor_Sair(object sender, EventArgs e)
        {
            SairButton.ForeColor = Color.DarkOrange;
        }
        //Fim Muda Cor ao passar o mouse
    }
}
