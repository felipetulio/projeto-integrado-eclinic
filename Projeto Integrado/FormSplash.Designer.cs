namespace Projeto_Integrado
{
    partial class FormSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
            this.pnlFormSplash = new System.Windows.Forms.Panel();
            this.btnSairSplash = new System.Windows.Forms.Button();
            this.btnEntrarSplash = new System.Windows.Forms.Button();
            this.txtSenhaSplash = new System.Windows.Forms.TextBox();
            this.txtUsuárioSplash = new System.Windows.Forms.TextBox();
            this.lblSenhaSplash = new System.Windows.Forms.Label();
            this.lblUsuarioSplash = new System.Windows.Forms.Label();
            this.pnlFormSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormSplash
            // 
            this.pnlFormSplash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormSplash.Controls.Add(this.btnSairSplash);
            this.pnlFormSplash.Controls.Add(this.btnEntrarSplash);
            this.pnlFormSplash.Controls.Add(this.txtSenhaSplash);
            this.pnlFormSplash.Controls.Add(this.txtUsuárioSplash);
            this.pnlFormSplash.Controls.Add(this.lblSenhaSplash);
            this.pnlFormSplash.Controls.Add(this.lblUsuarioSplash);
            this.pnlFormSplash.Location = new System.Drawing.Point(244, 144);
            this.pnlFormSplash.Name = "pnlFormSplash";
            this.pnlFormSplash.Size = new System.Drawing.Size(271, 122);
            this.pnlFormSplash.TabIndex = 0;
            this.pnlFormSplash.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSairSplash
            // 
            this.btnSairSplash.BackColor = System.Drawing.Color.White;
            this.btnSairSplash.Location = new System.Drawing.Point(142, 86);
            this.btnSairSplash.Name = "btnSairSplash";
            this.btnSairSplash.Size = new System.Drawing.Size(75, 23);
            this.btnSairSplash.TabIndex = 4;
            this.btnSairSplash.Text = "Sair";
            this.btnSairSplash.UseVisualStyleBackColor = false;
            // 
            // btnEntrarSplash
            // 
            this.btnEntrarSplash.BackColor = System.Drawing.Color.White;
            this.btnEntrarSplash.Location = new System.Drawing.Point(43, 86);
            this.btnEntrarSplash.Name = "btnEntrarSplash";
            this.btnEntrarSplash.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarSplash.TabIndex = 3;
            this.btnEntrarSplash.Text = "Entrar";
            this.btnEntrarSplash.UseVisualStyleBackColor = false;
            // 
            // txtSenhaSplash
            // 
            this.txtSenhaSplash.BackColor = System.Drawing.Color.DarkGray;
            this.txtSenhaSplash.Location = new System.Drawing.Point(92, 43);
            this.txtSenhaSplash.Name = "txtSenhaSplash";
            this.txtSenhaSplash.Size = new System.Drawing.Size(125, 20);
            this.txtSenhaSplash.TabIndex = 2;
            // 
            // txtUsuárioSplash
            // 
            this.txtUsuárioSplash.BackColor = System.Drawing.Color.DarkGray;
            this.txtUsuárioSplash.Location = new System.Drawing.Point(92, 17);
            this.txtUsuárioSplash.Name = "txtUsuárioSplash";
            this.txtUsuárioSplash.Size = new System.Drawing.Size(125, 20);
            this.txtUsuárioSplash.TabIndex = 1;
            // 
            // lblSenhaSplash
            // 
            this.lblSenhaSplash.AutoSize = true;
            this.lblSenhaSplash.Location = new System.Drawing.Point(45, 46);
            this.lblSenhaSplash.Name = "lblSenhaSplash";
            this.lblSenhaSplash.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaSplash.TabIndex = 1;
            this.lblSenhaSplash.Text = "Senha:";
            // 
            // lblUsuarioSplash
            // 
            this.lblUsuarioSplash.AutoSize = true;
            this.lblUsuarioSplash.Location = new System.Drawing.Point(40, 20);
            this.lblUsuarioSplash.Name = "lblUsuarioSplash";
            this.lblUsuarioSplash.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioSplash.TabIndex = 0;
            this.lblUsuarioSplash.Text = "Usuário:";
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 307);
            this.Controls.Add(this.pnlFormSplash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Splash";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.pnlFormSplash.ResumeLayout(false);
            this.pnlFormSplash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormSplash;
        private System.Windows.Forms.TextBox txtSenhaSplash;
        private System.Windows.Forms.TextBox txtUsuárioSplash;
        private System.Windows.Forms.Label lblSenhaSplash;
        private System.Windows.Forms.Label lblUsuarioSplash;
        private System.Windows.Forms.Button btnSairSplash;
        private System.Windows.Forms.Button btnEntrarSplash;
    }
}