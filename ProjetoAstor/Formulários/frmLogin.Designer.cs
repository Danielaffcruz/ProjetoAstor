namespace ProjetoAstor.Formulários
{
    partial class frmLogin
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
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.lblSenha);
            this.grpDados.Controls.Add(this.lblUsuario);
            this.grpDados.Controls.Add(this.btnCancelar);
            this.grpDados.Controls.Add(this.btnLogin);
            this.grpDados.Controls.Add(this.txtSenha);
            this.grpDados.Controls.Add(this.txtUsuario);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(239, 236);
            this.grpDados.TabIndex = 1;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados do Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(6, 115);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(7, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(134, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(28, 193);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 131);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(227, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(6, 63);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grpDados);
            this.Name = "frmLogin";
            this.Text = ".:::LOGIN:::.";
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}