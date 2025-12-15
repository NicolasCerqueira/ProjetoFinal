using IFSPStore.App.Cadastros;
using IFSPStore.App.Infra;
using IFSPStore.App.Outros;
using IFSPStore.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Colors;

namespace IFSPStore.App
{
    public partial class MainForm : MaterialForm
    {
        public static Funcionario? User { get; set; }
        public MainForm()
        {
            InitializeComponent();
            loadLogin();
            foreach (Control ctl in this.Controls)
            {
                
                if (ctl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.LightGreen;
                    mdiClient.BackgroundImage = Properties.Resources.LogoDriveNow;

                    break;
                }
            }
        }
        private void tema()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //tema dark
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Define a paleta de cores
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green900,        // Cor Primária (Barra de Título): Verde bem escuro
                Primary.Grey900,         // Cor Primária Escura (Barra de Status): Quase preto
                Primary.Green500,        // Cor Primária Clara: Um verde médio para detalhes
                Accent.LightGreen400,    // cor dos botoes
                TextShade.WHITE          // Texto Branco 
            );
            // ---------------------------------------------------------
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

