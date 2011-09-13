namespace Projeto_Integrado
{
    partial class FormExclusaoExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExclusaoExame));
            this.dgvExclusaoExame = new System.Windows.Forms.DataGridView();
            this.btnCancelarOp = new System.Windows.Forms.Button();
            this.btnExcluirExame = new System.Windows.Forms.Button();
            this.btnOKExclusaoExame = new System.Windows.Forms.Button();
            this.txtDataExclusaoExame = new System.Windows.Forms.TextBox();
            this.txtPacienteExclusaoExame = new System.Windows.Forms.TextBox();
            this.lblDataExclusaoExame = new System.Windows.Forms.Label();
            this.lblPacienteExclusaoExame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExclusaoExame)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExclusaoExame
            // 
            this.dgvExclusaoExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExclusaoExame.Location = new System.Drawing.Point(12, 99);
            this.dgvExclusaoExame.Name = "dgvExclusaoExame";
            this.dgvExclusaoExame.Size = new System.Drawing.Size(626, 323);
            this.dgvExclusaoExame.TabIndex = 15;
            // 
            // btnCancelarOp
            // 
            this.btnCancelarOp.Location = new System.Drawing.Point(563, 451);
            this.btnCancelarOp.Name = "btnCancelarOp";
            this.btnCancelarOp.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarOp.TabIndex = 5;
            this.btnCancelarOp.Text = "Cancelar";
            this.btnCancelarOp.UseVisualStyleBackColor = true;
            // 
            // btnExcluirExame
            // 
            this.btnExcluirExame.Location = new System.Drawing.Point(482, 451);
            this.btnExcluirExame.Name = "btnExcluirExame";
            this.btnExcluirExame.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirExame.TabIndex = 4;
            this.btnExcluirExame.Text = "Excluir";
            this.btnExcluirExame.UseVisualStyleBackColor = true;
            // 
            // btnOKExclusaoExame
            // 
            this.btnOKExclusaoExame.Location = new System.Drawing.Point(313, 55);
            this.btnOKExclusaoExame.Name = "btnOKExclusaoExame";
            this.btnOKExclusaoExame.Size = new System.Drawing.Size(33, 20);
            this.btnOKExclusaoExame.TabIndex = 3;
            this.btnOKExclusaoExame.Text = "OK";
            this.btnOKExclusaoExame.UseVisualStyleBackColor = true;
            // 
            // txtDataExclusaoExame
            // 
            this.txtDataExclusaoExame.Location = new System.Drawing.Point(207, 55);
            this.txtDataExclusaoExame.Name = "txtDataExclusaoExame";
            this.txtDataExclusaoExame.Size = new System.Drawing.Size(100, 20);
            this.txtDataExclusaoExame.TabIndex = 2;
            // 
            // txtPacienteExclusaoExame
            // 
            this.txtPacienteExclusaoExame.Location = new System.Drawing.Point(207, 29);
            this.txtPacienteExclusaoExame.Name = "txtPacienteExclusaoExame";
            this.txtPacienteExclusaoExame.Size = new System.Drawing.Size(260, 20);
            this.txtPacienteExclusaoExame.TabIndex = 1;
            // 
            // lblDataExclusaoExame
            // 
            this.lblDataExclusaoExame.AutoSize = true;
            this.lblDataExclusaoExame.Location = new System.Drawing.Point(168, 59);
            this.lblDataExclusaoExame.Name = "lblDataExclusaoExame";
            this.lblDataExclusaoExame.Size = new System.Drawing.Size(33, 13);
            this.lblDataExclusaoExame.TabIndex = 9;
            this.lblDataExclusaoExame.Text = "Data:";
            // 
            // lblPacienteExclusaoExame
            // 
            this.lblPacienteExclusaoExame.AutoSize = true;
            this.lblPacienteExclusaoExame.Location = new System.Drawing.Point(149, 32);
            this.lblPacienteExclusaoExame.Name = "lblPacienteExclusaoExame";
            this.lblPacienteExclusaoExame.Size = new System.Drawing.Size(52, 13);
            this.lblPacienteExclusaoExame.TabIndex = 8;
            this.lblPacienteExclusaoExame.Text = "Paciente:";
            // 
            // FormExclusaoExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 503);
            this.Controls.Add(this.dgvExclusaoExame);
            this.Controls.Add(this.btnCancelarOp);
            this.Controls.Add(this.btnExcluirExame);
            this.Controls.Add(this.btnOKExclusaoExame);
            this.Controls.Add(this.txtDataExclusaoExame);
            this.Controls.Add(this.txtPacienteExclusaoExame);
            this.Controls.Add(this.lblDataExclusaoExame);
            this.Controls.Add(this.lblPacienteExclusaoExame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExclusaoExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclusão de Exames";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExclusaoExame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExclusaoExame;
        private System.Windows.Forms.Button btnCancelarOp;
        private System.Windows.Forms.Button btnExcluirExame;
        private System.Windows.Forms.Button btnOKExclusaoExame;
        private System.Windows.Forms.TextBox txtDataExclusaoExame;
        private System.Windows.Forms.TextBox txtPacienteExclusaoExame;
        private System.Windows.Forms.Label lblDataExclusaoExame;
        private System.Windows.Forms.Label lblPacienteExclusaoExame;
    }
}