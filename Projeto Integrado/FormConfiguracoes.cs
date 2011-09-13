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
    public partial class FormConfiguracoes : Form
    {
        public FormConfiguracoes()
        {
            InitializeComponent();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            FormAlterarSenha callAS = new FormAlterarSenha();
            callAS.Show();
        }
    }
}
