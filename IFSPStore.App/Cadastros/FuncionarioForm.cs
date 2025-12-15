using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;

namespace IFSPStore.App.Cadastros
{
    public partial class FuncionarioForm : BaseForm
    {
        private readonly IBaseService<Funcionario> _usuarioServico;
        private List<FuncionarioModel>? usuarios;
        public FuncionarioForm(IBaseService<Funcionario> userService)
        {
            _usuarioServico = userService;
            InitializeComponent();
            if (!IsEditMode)
            {
                txtDataRegistro.Text = DateTime.Now.ToString("g");
                txtUltimoLogin.Text = DateTime.Now.ToString("g");
            }
        }
        private void PreencheObjeto(Funcionario user)
        {
            user.Nome = txtNome.Text;
            user.Email = txtEmail.Text;
            user.Login = txtUsuario.Text;
            user.Senha = txtSenha.Text;
            user.Ativo = chkAtivo.Checked;
            if (user.Id == 0)
            {
                user.DataRegistro = DateTime.Now;
                user.UltimoLogin = DateTime.Now; 
            }
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    // MODO EDIÇÃO
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var user = _usuarioServico.GetById<Funcionario>(id);
                        if (user != null)
                        {
                            PreencheObjeto(user);
                            user = _usuarioServico.Update<Funcionario, Funcionario, FuncionarioValidator>(user);
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado no banco de dados.");
                        }
                    }
                }
                else
                {
                    var user = new Funcionario();
                    PreencheObjeto(user);
                    _usuarioServico.Add<Funcionario, Funcionario, FuncionarioValidator>(user);
                }
                CarregaGrid();
                tabControlRegister.SelectedIndex = 1; // Volta para a lista
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _usuarioServico.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            usuarios = _usuarioServico.Get<FuncionarioModel>().ToList();
            dataGridViewList.DataSource = usuarios;
            dataGridViewList.Columns["Senha"]!.Visible = false;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewList.Columns["DataRegistro"].HeaderText = "Data de registro";
            dataGridViewList.Columns["UltimoLogin"].HeaderText = "Ultimo login";
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtUsuario.Text = linha?.Cells["Login"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
            chkAtivo.Checked = (bool)(linha?.Cells["Ativo"].Value ?? false);

            txtDataRegistro.Text = DateTime.TryParse(linha?.Cells["DataRegistro"].Value.ToString(), out var dataC)
                ? dataC.ToString("g")
                : "";

            txtUltimoLogin.Text = DateTime.TryParse(linha?.Cells["UltimoLogin"].Value.ToString(), out var dataL)
                ? dataL.ToString("g")
                : "";
        }
        protected override void GridToForm(DataGridViewRow? row)
        {
            if (row != null)
            {
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtUsuario.Text = row.Cells["Login"].Value.ToString();

                if (row.Cells["Ativo"].Value != null)
                {
                    chkAtivo.Checked = (bool)row.Cells["Ativo"].Value;
                }
            }
        }
    }
}
