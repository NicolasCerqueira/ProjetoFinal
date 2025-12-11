using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
using ReaLTaiizor.Forms;
using System.Data;
using System.Linq;

namespace IFSPStore.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<Funcionario> _usuarioServico;
        public Login(IBaseService<Funcionario> usuarioServico)
        {
            _usuarioServico = usuarioServico;
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Funcionario? user = searchUser(txtUsuario.Text, txtSenha.Text);
            if (user != null)
            {
                if (!user.Ativo)
                {
                    MessageBox.Show("Este usuário está inativo.",
                                    "DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (user != null)
            {
                user.UltimoLogin = DateTime.Now;
                _usuarioServico.Update<Funcionario, Funcionario, FuncionarioValidator>(user); MainForm.User = user; 

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }
        private Funcionario? searchUser(string login, string password)
        {
            checkValidUser();
            var user = _usuarioServico.Get<Funcionario>().Where(u => u.Login == login && u.Senha == password)
                .FirstOrDefault();
            return user;
        }

        private void checkValidUser()
        {
            var users = _usuarioServico.Get<Funcionario>().ToList();
            if (!users.Any(u => u.Login == "admin"))
            {
                var user = new Funcionario
                {
                    Login = "admin",
                    Senha = "admin",
                    Nome = "Administrator do sistema",
                    Ativo = true,
                    DataRegistro = DateTime.Now,
                    UltimoLogin = DateTime.Now,
                    Email = "admin@gmail.com",
                };
                _usuarioServico.Add<Funcionario, Funcionario, FuncionarioValidator>(user);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
