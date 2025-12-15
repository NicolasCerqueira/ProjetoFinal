using IFSPStore.App.Cadastros;
using IFSPStore.App.Infra;
using IFSPStore.App.Outros;
using IFSPStore.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace IFSPStore.App
{
    public partial class MainForm : MaterialForm
    {
        public static Funcionario? User { get; set; }
        public MainForm()
        {
            InitializeComponent();
            loadLogin();
            tema();
        }
        private void tema()
        {
            foreach (Control ctl in this.Controls)
            {

                if (ctl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.LightGreen;
                    mdiClient.BackgroundImage = Properties.Resources.DriveNow4k;

                    break;
                }
            }
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //tema dark
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }
        private void loadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUser.Text = $"Usuário: {User?.Nome}";
                }
            }
        }
        private void categorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<CategoriaForm>();
        }
        void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<CarroForm>();
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<ClienteForm>();
        }
        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<LocacaoForm>();
        }
        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<CidadeForm>();
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<FuncionarioForm>();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<HelpForm>();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            showForm<FuncionarioForm>();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            showForm<ClienteForm>();
        }

        private void btnCidade_Click(object sender, EventArgs e)
        {
            showForm<CidadeForm>();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            showForm<CategoriaForm>();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            showForm<CarroForm>();
        }

        private void btnAluguel_Click(object sender, EventArgs e)
        {
            showForm<LocacaoForm>();
        }

        private void showForm<TFormulario>() where TFormulario : MaterialForm
        {
            //fecha todos os forms abertos dentro do mdi
            foreach (var forms in this.MdiChildren)
            {
                forms.Close();
            }
            var form = ConfigureDI.serviceProvider!.GetService<TFormulario>();
            if (form != null && !form.IsDisposed)
            {
                form.MdiParent = this;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
        }
    }
}

