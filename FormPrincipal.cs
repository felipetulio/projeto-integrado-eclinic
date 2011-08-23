using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Integrado
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void marcaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarcacaoConsulta callMC = new FormMarcacaoConsulta();
            callMC.ShowDialog();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPaciente callCP = new FormPaciente();
            callCP.ShowDialog();
        }

        private void médicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMedico callCM = new FormMedico();
            callCM.ShowDialog();
        }

        private void técnicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTecnico callCT = new FormTecnico();
            callCT.ShowDialog();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesqPaciente callPP = new FormPesqPaciente();
            callPP.ShowDialog();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesqMedico callPM = new FormPesqMedico();
            callPM.ShowDialog();
        }

        private void técnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesqTecnico callPT = new FormPesqTecnico();
            callPT.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgenda callAC = new FormAgenda();
            callAC.ShowDialog();
        }

        private void exclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExclusaoConsulta callEC = new FormExclusaoConsulta();
            callEC.ShowDialog();
        }
    }
}
