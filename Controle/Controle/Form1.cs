namespace Controle
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "Teste123@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                MessageBox.Show("Bem-vindo ao sistema solar!");
                frmCadastro tela = new frmCadastro();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }
    }
}
