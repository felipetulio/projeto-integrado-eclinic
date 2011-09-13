namespace Projeto_Integrado
{
    partial class FormAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            this.lblMedicoAgenda = new System.Windows.Forms.Label();
            this.txtDataAgendaConsulta = new System.Windows.Forms.TextBox();
            this.btnOKAgenda = new System.Windows.Forms.Button();
            this.dgvMedicoAgenda = new System.Windows.Forms.DataGridView();
            this.lblDataAgendaConsulta = new System.Windows.Forms.Label();
            this.cbxMedicoAgendaConsulta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicoAgenda
            // 
            this.lblMedicoAgenda.AutoSize = true;
            this.lblMedicoAgenda.Location = new System.Drawing.Point(186, 31);
            this.lblMedicoAgenda.Name = "lblMedicoAgenda";
            this.lblMedicoAgenda.Size = new System.Drawing.Size(45, 13);
            this.lblMedicoAgenda.TabIndex = 0;
            this.lblMedicoAgenda.Text = "Médico:";
            // 
            // txtDataAgendaConsulta
            // 
            this.txtDataAgendaConsulta.Location = new System.Drawing.Point(237, 55);
            this.txtDataAgendaConsulta.Name = "txtDataAgendaConsulta";
            this.txtDataAgendaConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtDataAgendaConsulta.TabIndex = 2;
            // 
            // btnOKAgenda
            // 
            this.btnOKAgenda.Location = new System.Drawing.Point(343, 55);
            this.btnOKAgenda.Name = "btnOKAgenda";
            this.btnOKAgenda.Size = new System.Drawing.Size(33, 20);
            this.btnOKAgenda.TabIndex = 3;
            this.btnOKAgenda.Text = "OK";
            this.btnOKAgenda.UseVisualStyleBackColor = true;
            // 
            // dgvMedicoAgenda
            // 
            this.dgvMedicoAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicoAgenda.Location = new System.Drawing.Point(12, 118);
            this.dgvMedicoAgenda.Name = "dgvMedicoAgenda";
            this.dgvMedicoAgenda.Size = new System.Drawing.Size(626, 373);
            this.dgvMedicoAgenda.TabIndex = 3;
            // 
            // lblDataAgendaConsulta
            // 
            this.lblDataAgendaConsulta.AutoSize = true;
            this.lblDataAgendaConsulta.Location = new System.Drawing.Point(198, 58);
            this.lblDataAgendaConsulta.Name = "lblDataAgendaConsulta";
            this.lblDataAgendaConsulta.Size = new System.Drawing.Size(33, 13);
            this.lblDataAgendaConsulta.TabIndex = 4;
            this.lblDataAgendaConsulta.Text = "Data:";
            // 
            // cbxMedicoAgendaConsulta
            // 
            this.cbxMedicoAgendaConsulta.FormattingEnabled = true;
            this.cbxMedicoAgendaConsulta.Location = new System.Drawing.Point(237, 28);
            this.cbxMedicoAgendaConsulta.Name = "cbxMedicoAgendaConsulta";
            this.cbxMedicoAgendaConsulta.Size = new System.Drawing.Size(212, 21);
            this.cbxMedicoAgendaConsulta.TabIndex = 1;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 503);
            this.Controls.Add(this.cbxMedicoAgendaConsulta);
            this.Controls.Add(this.lblDataAgendaConsulta);
            this.Controls.Add(this.dgvMedicoAgenda);
            this.Controls.Add(this.btnOKAgenda);
            this.Controls.Add(this.txtDataAgendaConsulta);
            this.Controls.Add(this.lblMedicoAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda dos Médicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicoAgenda;
        private System.Windows.Forms.TextBox txtDataAgendaConsulta;
        private System.Windows.Forms.Button btnOKAgenda;
        private System.Windows.Forms.DataGridView dgvMedicoAgenda;
        private System.Windows.Forms.Label lblDataAgendaConsulta;
        private System.Windows.Forms.ComboBox cbxMedicoAgendaConsulta;
    }
}