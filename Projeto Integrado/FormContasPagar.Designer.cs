namespace Projeto_Integrado
{
    partial class FormContasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContasPagar));
            this.lblBeneficiadoContaPagar = new System.Windows.Forms.Label();
            this.txtBeneficiadoContaPagar = new System.Windows.Forms.TextBox();
            this.lblValorContaPagar = new System.Windows.Forms.Label();
            this.txtValorContaPagar = new System.Windows.Forms.TextBox();
            this.lblFormaPagamentoContaPagar = new System.Windows.Forms.Label();
            this.lblTipoContaPagar = new System.Windows.Forms.Label();
            this.lblVencimentoContaPagar = new System.Windows.Forms.Label();
            this.txtVencContaPagar = new System.Windows.Forms.TextBox();
            this.lblObservacaoContaPagar = new System.Windows.Forms.Label();
            this.txtObsContaPagar = new System.Windows.Forms.TextBox();
            this.btnSalvarContaPagar = new System.Windows.Forms.Button();
            this.btnCancelarContaPagar = new System.Windows.Forms.Button();
            this.cbxTipoContaContaPagar = new System.Windows.Forms.ComboBox();
            this.cbxFormaPagContaPagar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBeneficiadoContaPagar
            // 
            this.lblBeneficiadoContaPagar.AutoSize = true;
            this.lblBeneficiadoContaPagar.Location = new System.Drawing.Point(33, 41);
            this.lblBeneficiadoContaPagar.Name = "lblBeneficiadoContaPagar";
            this.lblBeneficiadoContaPagar.Size = new System.Drawing.Size(66, 13);
            this.lblBeneficiadoContaPagar.TabIndex = 0;
            this.lblBeneficiadoContaPagar.Text = "Beneficiado:";
            // 
            // txtBeneficiadoContaPagar
            // 
            this.txtBeneficiadoContaPagar.Location = new System.Drawing.Point(105, 38);
            this.txtBeneficiadoContaPagar.Name = "txtBeneficiadoContaPagar";
            this.txtBeneficiadoContaPagar.Size = new System.Drawing.Size(363, 20);
            this.txtBeneficiadoContaPagar.TabIndex = 1;
            this.txtBeneficiadoContaPagar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblValorContaPagar
            // 
            this.lblValorContaPagar.AutoSize = true;
            this.lblValorContaPagar.Location = new System.Drawing.Point(65, 75);
            this.lblValorContaPagar.Name = "lblValorContaPagar";
            this.lblValorContaPagar.Size = new System.Drawing.Size(34, 13);
            this.lblValorContaPagar.TabIndex = 2;
            this.lblValorContaPagar.Text = "Valor:";
            // 
            // txtValorContaPagar
            // 
            this.txtValorContaPagar.Location = new System.Drawing.Point(105, 72);
            this.txtValorContaPagar.Name = "txtValorContaPagar";
            this.txtValorContaPagar.Size = new System.Drawing.Size(104, 20);
            this.txtValorContaPagar.TabIndex = 2;
            // 
            // lblFormaPagamentoContaPagar
            // 
            this.lblFormaPagamentoContaPagar.AutoSize = true;
            this.lblFormaPagamentoContaPagar.Location = new System.Drawing.Point(224, 75);
            this.lblFormaPagamentoContaPagar.Name = "lblFormaPagamentoContaPagar";
            this.lblFormaPagamentoContaPagar.Size = new System.Drawing.Size(111, 13);
            this.lblFormaPagamentoContaPagar.TabIndex = 4;
            this.lblFormaPagamentoContaPagar.Text = "Forma de Pagamento:";
            // 
            // lblTipoContaPagar
            // 
            this.lblTipoContaPagar.AutoSize = true;
            this.lblTipoContaPagar.Location = new System.Drawing.Point(22, 107);
            this.lblTipoContaPagar.Name = "lblTipoContaPagar";
            this.lblTipoContaPagar.Size = new System.Drawing.Size(77, 13);
            this.lblTipoContaPagar.TabIndex = 6;
            this.lblTipoContaPagar.Text = "Tipo de Conta:";
            // 
            // lblVencimentoContaPagar
            // 
            this.lblVencimentoContaPagar.AutoSize = true;
            this.lblVencimentoContaPagar.Location = new System.Drawing.Point(269, 110);
            this.lblVencimentoContaPagar.Name = "lblVencimentoContaPagar";
            this.lblVencimentoContaPagar.Size = new System.Drawing.Size(66, 13);
            this.lblVencimentoContaPagar.TabIndex = 8;
            this.lblVencimentoContaPagar.Text = "Vencimento:";
            // 
            // txtVencContaPagar
            // 
            this.txtVencContaPagar.Location = new System.Drawing.Point(341, 107);
            this.txtVencContaPagar.Name = "txtVencContaPagar";
            this.txtVencContaPagar.Size = new System.Drawing.Size(127, 20);
            this.txtVencContaPagar.TabIndex = 5;
            // 
            // lblObservacaoContaPagar
            // 
            this.lblObservacaoContaPagar.AutoSize = true;
            this.lblObservacaoContaPagar.Location = new System.Drawing.Point(31, 143);
            this.lblObservacaoContaPagar.Name = "lblObservacaoContaPagar";
            this.lblObservacaoContaPagar.Size = new System.Drawing.Size(68, 13);
            this.lblObservacaoContaPagar.TabIndex = 10;
            this.lblObservacaoContaPagar.Text = "Observação:";
            // 
            // txtObsContaPagar
            // 
            this.txtObsContaPagar.Location = new System.Drawing.Point(105, 143);
            this.txtObsContaPagar.Multiline = true;
            this.txtObsContaPagar.Name = "txtObsContaPagar";
            this.txtObsContaPagar.Size = new System.Drawing.Size(363, 77);
            this.txtObsContaPagar.TabIndex = 6;
            // 
            // btnSalvarContaPagar
            // 
            this.btnSalvarContaPagar.Location = new System.Drawing.Point(312, 263);
            this.btnSalvarContaPagar.Name = "btnSalvarContaPagar";
            this.btnSalvarContaPagar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarContaPagar.TabIndex = 7;
            this.btnSalvarContaPagar.Text = "Salvar";
            this.btnSalvarContaPagar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarContaPagar
            // 
            this.btnCancelarContaPagar.Location = new System.Drawing.Point(393, 263);
            this.btnCancelarContaPagar.Name = "btnCancelarContaPagar";
            this.btnCancelarContaPagar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarContaPagar.TabIndex = 8;
            this.btnCancelarContaPagar.Text = "Cancelar";
            this.btnCancelarContaPagar.UseVisualStyleBackColor = true;
            // 
            // cbxTipoContaContaPagar
            // 
            this.cbxTipoContaContaPagar.FormattingEnabled = true;
            this.cbxTipoContaContaPagar.Location = new System.Drawing.Point(103, 104);
            this.cbxTipoContaContaPagar.Name = "cbxTipoContaContaPagar";
            this.cbxTipoContaContaPagar.Size = new System.Drawing.Size(106, 21);
            this.cbxTipoContaContaPagar.TabIndex = 4;
            // 
            // cbxFormaPagContaPagar
            // 
            this.cbxFormaPagContaPagar.FormattingEnabled = true;
            this.cbxFormaPagContaPagar.Location = new System.Drawing.Point(341, 72);
            this.cbxFormaPagContaPagar.Name = "cbxFormaPagContaPagar";
            this.cbxFormaPagContaPagar.Size = new System.Drawing.Size(127, 21);
            this.cbxFormaPagContaPagar.TabIndex = 3;
            // 
            // FormContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 312);
            this.Controls.Add(this.cbxFormaPagContaPagar);
            this.Controls.Add(this.cbxTipoContaContaPagar);
            this.Controls.Add(this.btnCancelarContaPagar);
            this.Controls.Add(this.btnSalvarContaPagar);
            this.Controls.Add(this.txtObsContaPagar);
            this.Controls.Add(this.lblObservacaoContaPagar);
            this.Controls.Add(this.txtVencContaPagar);
            this.Controls.Add(this.lblVencimentoContaPagar);
            this.Controls.Add(this.lblTipoContaPagar);
            this.Controls.Add(this.lblFormaPagamentoContaPagar);
            this.Controls.Add(this.txtValorContaPagar);
            this.Controls.Add(this.lblValorContaPagar);
            this.Controls.Add(this.txtBeneficiadoContaPagar);
            this.Controls.Add(this.lblBeneficiadoContaPagar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.FormContasPagar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeneficiadoContaPagar;
        private System.Windows.Forms.TextBox txtBeneficiadoContaPagar;
        private System.Windows.Forms.Label lblValorContaPagar;
        private System.Windows.Forms.TextBox txtValorContaPagar;
        private System.Windows.Forms.Label lblFormaPagamentoContaPagar;
        private System.Windows.Forms.Label lblTipoContaPagar;
        private System.Windows.Forms.Label lblVencimentoContaPagar;
        private System.Windows.Forms.TextBox txtVencContaPagar;
        private System.Windows.Forms.Label lblObservacaoContaPagar;
        private System.Windows.Forms.TextBox txtObsContaPagar;
        private System.Windows.Forms.Button btnSalvarContaPagar;
        private System.Windows.Forms.Button btnCancelarContaPagar;
        private System.Windows.Forms.ComboBox cbxTipoContaContaPagar;
        private System.Windows.Forms.ComboBox cbxFormaPagContaPagar;
    }
}