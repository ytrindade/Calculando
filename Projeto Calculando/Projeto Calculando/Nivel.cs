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
    public partial class Nivel : Form
    {
        public Nivel()
        {
            InitializeComponent();
        }

        //Retorna para Operações ao ser clicado
        Thread t1niveis;
        private void VoltarButtonNiveis_Click(object sender, EventArgs e)
        {
            this.Close();
            t1niveis = new Thread(VoltarParaOperacoes_niveis);
            t1niveis.SetApartmentState(ApartmentState.STA);
            t1niveis.Start();
        }

        private void VoltarParaOperacoes_niveis(object obj)
        {
            Application.Run(new Operacoes());
        }
        //

        //Muda Cor ao passar o mouse
        private void MudaCor_FacilButton(object sender, EventArgs e)
        {
            FacilButton.ForeColor = Color.White;
        }

        private void VoltaCor_FacilButton(object sender, EventArgs e)
        {
            FacilButton.ForeColor = Color.DarkOrange;
        }

        private void MudaCor_MedioButton(object sender, EventArgs e)
        {
            MedioButton.ForeColor = Color.White;
        }

        private void VoltaCor_MedioButton(object sender, EventArgs e)
        {
            MedioButton.ForeColor = Color.DarkOrange;
        }

        private void MudaCor_DificilButton(object sender, EventArgs e)
        {
            DificilButton.ForeColor = Color.White;
        }

        private void VoltaCor_DificilButton(object sender, EventArgs e)
        {
            DificilButton.ForeColor = Color.DarkOrange;
        }

        private void MudaCor_VoltarNiveislbl(object sender, EventArgs e)
        {
            VoltarNiveislbl.ForeColor = Color.White;
        }

        private void VoltaCor_VoltarNiveislbl(object sender, EventArgs e)
        {
            VoltarNiveislbl.ForeColor = Color.DarkOrange;   
        }
        //Fim Muda Cor ao passar o mouse


    }
}
