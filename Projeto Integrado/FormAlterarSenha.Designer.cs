namespace Projeto_Integrado
{
    partial class FormAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarSenha));
            this.lblSenhaAntiga = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblConfirmeNovaSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.brnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSenhaAntiga
            // 
            this.lblSenhaAntiga.AutoSize = true;
            this.lblSenhaAntiga.Location = new System.Drawing.Point(45, 35);
            this.lblSenhaAntiga.Name = "lblSenhaAntiga";
            this.lblSenhaAntiga.Size = new System.Drawing.Size(74, 13);
            this.lblSenhaAntiga.TabIndex = 0;
            this.lblSenhaAntiga.Text = "Senha Antiga:";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Location = new System.Drawing.Point(49, 61);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(70, 13);
            this.lblNovaSenha.TabIndex = 1;
            this.lblNovaSenha.Text = "Nova Senha:";
            // 
            // lblConfirmeNovaSenha
            // 
            this.lblConfirmeNovaSenha.AutoSize = true;
            this.lblConfirmeNovaSenha.Location = new System.Drawing.Point(5, 87);
            this.lblConfirmeNovaSenha.Name = "lblConfirmeNovaSenha";
            this.lblConfirmeNovaSenha.Size = new System.Drawing.Size(114, 13);
            this.lblConfirmeNovaSenha.TabIndex = 2;
            this.lblConfirmeNovaSenha.Text = "Confirme Nova Senha:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 5;
            // 
            // brnConfirmar
            // 
            this.brnConfirmar.Location = new System.Drawing.Point(61, 140);
            this.brnConfirmar.Name = "brnConfirmar";
            this.brnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.brnConfirmar.TabIndex = 6;
            this.brnConfirmar.Text = "Confirmar";
            this.brnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(142, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.brnConfirmar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConfirmeNovaSenha);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.lblSenhaAntiga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenhaAntiga;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblConfirmeNovaSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button brnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}