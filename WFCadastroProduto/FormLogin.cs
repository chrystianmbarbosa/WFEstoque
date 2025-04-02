namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Id = 1;
            user.Login = "admin";
            user.Senha = "123456";
            user.Nome = "Administrador do Sistema";
            user.DataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(user);

            user = new Usuario();
            user.Id = 2;
            user.Login = "user";
            user.Senha = "123456789";
            user.Nome = "Usuário do Sistema";
            user.DataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(user);

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            foreach (Usuario us in Usuario.ListaUsuarios)
            {
                if (us.Login == txtLogin.Text
                    && us.Senha == txtSenha.Text)
                {
                    FormMenu form = new FormMenu();
                    form.ShowDialog();
                    return;
                }
            }
            Erro("Usuario não Autenticado!");

        }

        private void Erro(string messagem)
        {
            MessageBox.Show(messagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(sender, e);
            }
        }
    }
}
