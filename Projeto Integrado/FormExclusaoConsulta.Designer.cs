namespace Projeto_Integrado
{
    partial class FormExclusaoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExclusaoConsulta));
            this.lblPacienteExclusaoConsulta = new System.Windows.Forms.Label();
            this.lblDataExclusaoConsulta = new System.Windows.Forms.Label();
            this.txtPacienteExclusaoConsulta = new System.Windows.Forms.TextBox();
            this.txtDataExclusaoConsulta = new System.Windows.Forms.TextBox();
            this.btnOKExclusaoConsulta = new System.Windows.Forms.Button();
            this.btnExcluirConsulta = new System.Windows.Forms.Button();
            this.btnCancelarOp = new System.Windows.Forms.Button();
            this.dgvExclusaoConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExclusaoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPacienteExclusaoConsulta
            // 
            this.lblPacienteExclusaoConsulta.AutoSize = true;
            this.lblPacienteExclusaoConsulta.Location = new System.Drawing.Point(149, 31);
            this.lblPacienteExclusaoConsulta.Name = "lblPacienteExclusaoConsulta";
            this.lblPacienteExclusaoConsulta.Size = new System.Drawing.Size(52, 13);
            this.lblPacienteExclusaoConsulta.TabIndex = 0;
            this.lblPacienteExclusaoConsulta.Text = "Paciente:";
            // 
            // lblDataExclusaoConsulta
            // 
            this.lblDataExclusaoConsulta.AutoSize = true;
            this.lblDataExclusaoConsulta.Location = new System.Drawing.Point(168, 57);
            this.lblDataExclusaoConsulta.Name = "lblDataExclusaoConsulta";
            this.lblDataExclusaoConsulta.Size = new System.Drawing.Size(33, 13);
            this.lblDataExclusaoConsulta.TabIndex = 1;
            this.lblDataExclusaoConsulta.Text = "Data:";
            // 
            // txtPacienteExclusaoConsulta
            // 
            this.txtPacienteExclusaoConsulta.Location = new System.Drawing.Point(207, 28);
            this.txtPacienteExclusaoConsulta.Name = "txtPacienteExclusaoConsulta";
            this.txtPacienteExclusaoConsulta.Size = new System.Drawing.Size(260, 20);
            this.txtPacienteExclusaoConsulta.TabIndex = 1;
            // 
            // txtDataExclusaoConsulta
            // 
            this.txtDataExclusaoConsulta.Location = new System.Drawing.Point(207, 54);
            this.txtDataExclusaoConsulta.Name = "txtDataExclusaoConsulta";
            this.txtDataExclusaoConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtDataExclusaoConsulta.TabIndex = 2;
            // 
            // btnOKExclusaoConsulta
            // 
            this.btnOKExclusaoConsulta.Location = new System.Drawing.Point(313, 54);
            this.btnOKExclusaoConsulta.Name = "btnOKExclusaoConsulta";
            this.btnOKExclusaoConsulta.Size = new System.Drawing.Size(33, 20);
            this.btnOKExclusaoConsulta.TabIndex = 3;
            this.btnOKExclusaoConsulta.Text = "OK";
            this.btnOKExclusaoConsulta.UseVisualStyleBackColor = true;
            // 
            // btnExcluirConsulta
            // 
            this.btnExcluirConsulta.Location = new System.Drawing.Point(482, 450);
            this.btnExcluirConsulta.Name = "btnExcluirConsulta";
            this.btnExcluirConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirConsulta.TabIndex = 4;
            this.btnExcluirConsulta.Text = "Excluir";
            this.btnExcluirConsulta.UseVisualStyleBackColor = true;
            // 
            // btnCancelarOp
            // 
            this.btnCancelarOp.Location = new System.Drawing.Point(563, 450);
            this.btnCancelarOp.Name = "btnCancelarOp";
            this.btnCancelarOp.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarOp.TabIndex = 5;
            this.btnCancelarOp.Text = "Cancelar";
            this.btnCancelarOp.UseVisualStyleBackColor = true;
            // 
            // dgvExclusaoConsulta
            // 
            this.dgvExclusaoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExclusaoConsulta.Location = new System.Drawing.Point(12, 98);
            this.dgvExclusaoConsulta.Name = "dgvExclusaoConsulta";
            this.dgvExclusaoConsulta.Size = new System.Drawing.Size(626, 323);
            this.dgvExclusaoConsulta.TabIndex = 7;
            // 
            // FormExclusaoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 503);
            this.Controls.Add(this.dgvExclusaoConsulta);
            this.Controls.Add(this.btnCancelarOp);
            this.Controls.Add(this.btnExcluirConsulta);
            this.Controls.Add(this.btnOKExclusaoConsulta);
            this.Controls.Add(this.txtDataExclusaoConsulta);
            this.Controls.Add(this.txtPacienteExclusaoConsulta);
            this.Controls.Add(this.lblDataExclusaoConsulta);
            this.Controls.Add(this.lblPacienteExclusaoConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExclusaoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclusão de Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExclusaoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacienteExclusaoConsulta;
        private System.Windows.Forms.Label lblDataExclusaoConsulta;
        private System.Windows.Forms.TextBox txtPacienteExclusaoConsulta;
        private System.Windows.Forms.TextBox txtDataExclusaoConsulta;
        private System.Windows.Forms.Button btnOKExclusaoConsulta;
        private System.Windows.Forms.Button btnExcluirConsulta;
        private System.Windows.Forms.Button btnCancelarOp;
        private System.Windows.Forms.DataGridView dgvExclusaoConsulta;
    }
}