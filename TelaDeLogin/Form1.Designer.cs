namespace TelaDeLogin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnLogin;
        private Label lblMensagem;

        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";

            // txtUsuario
            this.txtUsuario.Location = new System.Drawing.Point(100, 27);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 23);
            this.txtUsuario.TabIndex = 1;

            // lblSenha
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(30, 70);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 15);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";

            // txtSenha
            this.txtSenha.Location = new System.Drawing.Point(100, 67);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(200, 23);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(100, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblMensagem
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(30, 160);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 15);
            this.lblMensagem.TabIndex = 5;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Form1";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
