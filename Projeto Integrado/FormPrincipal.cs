using System;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_Integrado
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(10000);
            th.Abort();
            Thread.Sleep(1000);

        }

        private void DoSplash()
        {
            FormSplash sp = new FormSplash();
            sp.ShowDialog();
        }

        private void marcaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarcacaoConsulta callMC = new FormMarcacaoConsulta();
            callMC.Show();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPaciente callCP = new FormPaciente();
            callCP.Show();
        }

        private void médicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMedico callCM = new FormMedico();
            callCM.Show();
        }

        private void técnicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTecnico callCT = new FormTecnico();
            callCT.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesqPaciente callPP = new FormPesqPaciente();
            callPP.Show();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesqMedico callPM = new FormPesqMedico();
            callPM.Show();
        }

        private void técnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesqTecnico callPT = new FormPesqTecnico();
            callPT.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgenda callAC = new FormAgenda();
            callAC.Show();
        }

        private void exclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExclusaoConsulta callEC = new FormExclusaoConsulta();
            callEC.Show();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContasReceber callCR = new FormContasReceber();
            callCR.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContasPagar callCP = new FormContasPagar();
            callCP.Show();
        }

        private void marcaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMarcacaoExame callME = new FormMarcacaoExame();
            callME.Show();
        }

        private void exclusãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExclusaoExame callEE = new FormExclusaoExame();
            callEE.Show();
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInformacao callI = new FormInformacao();
            callI.Show();
        }

        private void sobreOEDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracoes callC = new FormConfiguracoes();
            callC.Show();
        }

        private void agendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAgendaExame callAE = new FormAgendaExame();
            callAE.Show();
        }
    }
}
