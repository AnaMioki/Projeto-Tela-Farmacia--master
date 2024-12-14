using System;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento do botão Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Validação simples
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                lblMensagem.Text = "Por favor, preencha todos os campos.";
                lblMensagem.ForeColor = System.Drawing.Color.Red;
            }
            else if (usuario == "admin" && senha == "1234") // Credenciais fixas para teste
            {
                lblMensagem.Text = "Login realizado com sucesso!";
                lblMensagem.ForeColor = System.Drawing.Color.Green;

                // Abre o Menu Principal e fecha o formulário de login
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide(); // Esconde o formulário de login

                // Aqui você pode redirecionar para outra janela, se necessário.
                MessageBox.Show("Bem-vindo ao sistema!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblMensagem.Text = "Usuário ou senha inválidos.";
                lblMensagem.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
