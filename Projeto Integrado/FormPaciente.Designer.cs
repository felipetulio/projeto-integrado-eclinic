namespace Projeto_Integrado
{
    partial class FormPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaciente));
            this.gpbPacienteDPessoais = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbPacienteInformacoes = new System.Windows.Forms.GroupBox();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.txtDoencas = new System.Windows.Forms.TextBox();
            this.txtQual = new System.Windows.Forms.TextBox();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.lblDoenca = new System.Windows.Forms.Label();
            this.lblRemedioControlado = new System.Windows.Forms.Label();
            this.lblQual = new System.Windows.Forms.Label();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbPacienteDPessoais.SuspendLayout();
            this.gpbPacienteInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPacienteDPessoais
            // 
            this.gpbPacienteDPessoais.Controls.Add(this.txtNome);
            this.gpbPacienteDPessoais.Controls.Add(this.txtEndereco);
            this.gpbPacienteDPessoais.Controls.Add(this.txtRG);
            this.gpbPacienteDPessoais.Controls.Add(this.txtCPF);
            this.gpbPacienteDPessoais.Controls.Add(this.txtNasc);
            this.gpbPacienteDPessoais.Controls.Add(this.txtIdade);
            this.gpbPacienteDPessoais.Controls.Add(this.txtTelefone);
            this.gpbPacienteDPessoais.Controls.Add(this.txtEmail);
            this.gpbPacienteDPessoais.Controls.Add(this.txtSexo);
            this.gpbPacienteDPessoais.Controls.Add(this.lblEndereco);
            this.gpbPacienteDPessoais.Controls.Add(this.lblRG);
            this.gpbPacienteDPessoais.Controls.Add(this.lblCPF);
            this.gpbPacienteDPessoais.Controls.Add(this.lblIdade);
            this.gpbPacienteDPessoais.Controls.Add(this.lblTelefone);
            this.gpbPacienteDPessoais.Controls.Add(this.lblEmail);
            this.gpbPacienteDPessoais.Controls.Add(this.lblSexo);
            this.gpbPacienteDPessoais.Controls.Add(this.lblDataNasc);
            this.gpbPacienteDPessoais.Controls.Add(this.lblNome);
            this.gpbPacienteDPessoais.Location = new System.Drawing.Point(12, 27);
            this.gpbPacienteDPessoais.Name = "gpbPacienteDPessoais";
            this.gpbPacienteDPessoais.Size = new System.Drawing.Size(626, 185);
            this.gpbPacienteDPessoais.TabIndex = 0;
            this.gpbPacienteDPessoais.TabStop = false;
            this.gpbPacienteDPessoais.Text = "Dados Pessoais";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(543, 20);
            this.txtNome.TabIndex = 17;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(77, 53);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(543, 20);
            this.txtEndereco.TabIndex = 16;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(77, 82);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(135, 20);
            this.txtRG.TabIndex = 15;
            this.txtRG.TextChanged += new System.EventHandler(this.txtRG_TextChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(263, 82);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(149, 20);
            this.txtCPF.TabIndex = 14;
            // 
            // txtNasc
            // 
            this.txtNasc.Location = new System.Drawing.Point(536, 82);
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(84, 20);
            this.txtNasc.TabIndex = 13;
            this.txtNasc.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(77, 110);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 12;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(77, 140);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(263, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(357, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(263, 110);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(149, 20);
            this.txtSexo.TabIndex = 9;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(15, 56);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(45, 85);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 7;
            this.lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(228, 85);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(34, 113);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(19, 143);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(220, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(224, 113);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(430, 85);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(107, 13);
            this.lblDataNasc.TabIndex = 1;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // gpbPacienteInformacoes
            // 
            this.gpbPacienteInformacoes.Controls.Add(this.rbtNao);
            this.gpbPacienteInformacoes.Controls.Add(this.rbtSim);
            this.gpbPacienteInformacoes.Controls.Add(this.txtDoencas);
            this.gpbPacienteInformacoes.Controls.Add(this.txtQual);
            this.gpbPacienteInformacoes.Controls.Add(this.txtConvenio);
            this.gpbPacienteInformacoes.Controls.Add(this.lblDoenca);
            this.gpbPacienteInformacoes.Controls.Add(this.lblRemedioControlado);
            this.gpbPacienteInformacoes.Controls.Add(this.lblQual);
            this.gpbPacienteInformacoes.Controls.Add(this.lblConvenio);
            this.gpbPacienteInformacoes.Location = new System.Drawing.Point(12, 244);
            this.gpbPacienteInformacoes.Name = "gpbPacienteInformacoes";
            this.gpbPacienteInformacoes.Size = new System.Drawing.Size(626, 135);
            this.gpbPacienteInformacoes.TabIndex = 1;
            this.gpbPacienteInformacoes.TabStop = false;
            this.gpbPacienteInformacoes.Text = "Informações de saúde";
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Location = new System.Drawing.Point(575, 32);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(45, 17);
            this.rbtNao.TabIndex = 9;
            this.rbtNao.TabStop = true;
            this.rbtNao.Text = "Não";
            this.rbtNao.UseVisualStyleBackColor = true;
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.Location = new System.Drawing.Point(527, 32);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(42, 17);
            this.rbtSim.TabIndex = 8;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "Sim";
            this.rbtSim.UseVisualStyleBackColor = true;
            // 
            // txtDoencas
            // 
            this.txtDoencas.Location = new System.Drawing.Point(77, 57);
            this.txtDoencas.Multiline = true;
            this.txtDoencas.Name = "txtDoencas";
            this.txtDoencas.Size = new System.Drawing.Size(250, 62);
            this.txtDoencas.TabIndex = 7;
            // 
            // txtQual
            // 
            this.txtQual.Location = new System.Drawing.Point(398, 57);
            this.txtQual.Multiline = true;
            this.txtQual.Name = "txtQual";
            this.txtQual.Size = new System.Drawing.Size(222, 62);
            this.txtQual.TabIndex = 6;
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(77, 31);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(250, 20);
            this.txtConvenio.TabIndex = 4;
            // 
            // lblDoenca
            // 
            this.lblDoenca.AutoSize = true;
            this.lblDoenca.Location = new System.Drawing.Point(19, 60);
            this.lblDoenca.Name = "lblDoenca";
            this.lblDoenca.Size = new System.Drawing.Size(53, 13);
            this.lblDoenca.TabIndex = 3;
            this.lblDoenca.Text = "Doenças:";
            // 
            // lblRemedioControlado
            // 
            this.lblRemedioControlado.AutoSize = true;
            this.lblRemedioControlado.Location = new System.Drawing.Point(357, 36);
            this.lblRemedioControlado.Name = "lblRemedioControlado";
            this.lblRemedioControlado.Size = new System.Drawing.Size(164, 13);
            this.lblRemedioControlado.TabIndex = 2;
            this.lblRemedioControlado.Text = "Toma algum remédio controlado?";
            // 
            // lblQual
            // 
            this.lblQual.AutoSize = true;
            this.lblQual.Location = new System.Drawing.Point(357, 60);
            this.lblQual.Name = "lblQual";
            this.lblQual.Size = new System.Drawing.Size(35, 13);
            this.lblQual.TabIndex = 1;
            this.lblQual.Text = "Qual?";
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(19, 34);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(55, 13);
            this.lblConvenio.TabIndex = 0;
            this.lblConvenio.Text = "Convênio:";
            this.lblConvenio.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(12, 457);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 23);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Limpar Campos";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(474, 457);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(563, 457);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 503);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.gpbPacienteInformacoes);
            this.Controls.Add(this.gpbPacienteDPessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.gpbPacienteDPessoais.ResumeLayout(false);
            this.gpbPacienteDPessoais.PerformLayout();
            this.gpbPacienteInformacoes.ResumeLayout(false);
            this.gpbPacienteInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPacienteDPessoais;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.GroupBox gpbPacienteInformacoes;
        private System.Windows.Forms.Label lblDoenca;
        private System.Windows.Forms.Label lblRemedioControlado;
        private System.Windows.Forms.Label lblQual;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.TextBox txtDoencas;
        private System.Windows.Forms.TextBox txtQual;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.RadioButton rbtSim;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}