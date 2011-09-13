namespace Projeto_Integrado
{
    partial class FormAgendaExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgendaExame));
            this.dgvAgendaExame = new System.Windows.Forms.DataGridView();
            this.btnOKAgendaExame = new System.Windows.Forms.Button();
            this.lblProfissionalAgendaExame = new System.Windows.Forms.Label();
            this.cbxProfissionalAgendaExame = new System.Windows.Forms.ComboBox();
            this.lblDataAgendaExame = new System.Windows.Forms.Label();
            this.txtDataAgendaExame = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaExame)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgendaExame
            // 
            this.dgvAgendaExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaExame.Location = new System.Drawing.Point(12, 113);
            this.dgvAgendaExame.Name = "dgvAgendaExame";
            this.dgvAgendaExame.Size = new System.Drawing.Size(626, 373);
            this.dgvAgendaExame.TabIndex = 6;
            // 
            // btnOKAgendaExame
            // 
            this.btnOKAgendaExame.Location = new System.Drawing.Point(343, 55);
            this.btnOKAgendaExame.Name = "btnOKAgendaExame";
            this.btnOKAgendaExame.Size = new System.Drawing.Size(33, 20);
            this.btnOKAgendaExame.TabIndex = 3;
            this.btnOKAgendaExame.Text = "OK";
            this.btnOKAgendaExame.UseVisualStyleBackColor = true;
            // 
            // lblProfissionalAgendaExame
            // 
            this.lblProfissionalAgendaExame.AutoSize = true;
            this.lblProfissionalAgendaExame.Location = new System.Drawing.Point(168, 31);
            this.lblProfissionalAgendaExame.Name = "lblProfissionalAgendaExame";
            this.lblProfissionalAgendaExame.Size = new System.Drawing.Size(63, 13);
            this.lblProfissionalAgendaExame.TabIndex = 7;
            this.lblProfissionalAgendaExame.Text = "Profissional:";
            // 
            // cbxProfissionalAgendaExame
            // 
            this.cbxProfissionalAgendaExame.FormattingEnabled = true;
            this.cbxProfissionalAgendaExame.Location = new System.Drawing.Point(237, 28);
            this.cbxProfissionalAgendaExame.Name = "cbxProfissionalAgendaExame";
            this.cbxProfissionalAgendaExame.Size = new System.Drawing.Size(210, 21);
            this.cbxProfissionalAgendaExame.TabIndex = 1;
            // 
            // lblDataAgendaExame
            // 
            this.lblDataAgendaExame.AutoSize = true;
            this.lblDataAgendaExame.Location = new System.Drawing.Point(198, 60);
            this.lblDataAgendaExame.Name = "lblDataAgendaExame";
            this.lblDataAgendaExame.Size = new System.Drawing.Size(33, 13);
            this.lblDataAgendaExame.TabIndex = 9;
            this.lblDataAgendaExame.Text = "Data:";
            // 
            // txtDataAgendaExame
            // 
            this.txtDataAgendaExame.Location = new System.Drawing.Point(237, 55);
            this.txtDataAgendaExame.Name = "txtDataAgendaExame";
            this.txtDataAgendaExame.Size = new System.Drawing.Size(100, 20);
            this.txtDataAgendaExame.TabIndex = 2;
            // 
            // FormAgendaExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 503);
            this.Controls.Add(this.txtDataAgendaExame);
            this.Controls.Add(this.lblDataAgendaExame);
            this.Controls.Add(this.cbxProfissionalAgendaExame);
            this.Controls.Add(this.lblProfissionalAgendaExame);
            this.Controls.Add(this.dgvAgendaExame);
            this.Controls.Add(this.btnOKAgendaExame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgendaExame";
            this.Text = "Agenda de Exames";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaExame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgendaExame;
        private System.Windows.Forms.Button btnOKAgendaExame;
        private System.Windows.Forms.Label lblProfissionalAgendaExame;
        private System.Windows.Forms.ComboBox cbxProfissionalAgendaExame;
        private System.Windows.Forms.Label lblDataAgendaExame;
        private System.Windows.Forms.TextBox txtDataAgendaExame;
    }
}