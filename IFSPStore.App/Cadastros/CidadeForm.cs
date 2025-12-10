using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
namespace IFSPStore.App.Cadastros
{
    public partial class CidadeForm : BaseForm
    {
        private IBaseService<Cidade> _cidadeServico;
        private List<Cidade> cidades;
        public CidadeForm(IBaseService<Cidade> cidadeService)
        {
            _cidadeServico = cidadeService;
            InitializeComponent();
        }
        private void preencheObject(Cidade cidade)
        {
            cidade.Nome = txtNome.Text;
            cidade.Estado = cboEstado.Text;
        }
        protected override void Save()
        {
            try
            {
                int id = 0;
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out id);
                }

                // Lista de cidades ja cadastradas no banco
                var cidadesExistentes = _cidadeServico.Get<Cidade>();

                // Verifica se existe alguma cidade com o mesmo nome
                //qualquer dulicação ja implica em um cadastro invalido
                bool existeDuplicada = cidadesExistentes.Any(c =>
                    c.Nome.Trim().Equals(txtNome.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) &&
                    c.Estado.Trim().Equals(cboEstado.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) &&
                    c.Id != id);

                if (existeDuplicada)
                {
                    MessageBox.Show("Já existe uma cidade cadastrada com este nome.", @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // se tem cidade igual nao salva
                }
                if (IsEditMode)
                {
                    var cidade = _cidadeServico.GetById<Cidade>(id);
                    preencheObject(cidade);
                    cidade = _cidadeServico.Update<Cidade, Cidade, CidadeValidator>(cidade);
                    
                }
                else
                {
                    var cidade = new Cidade();
                    preencheObject(cidade);
                    _cidadeServico.Add<Cidade, Cidade, CidadeValidator>(cidade);

                }
                tabControlRegister.SelectedIndex = 1;
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Delete(int id)
        {
            try
            {
                _cidadeServico.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            cidades = _cidadeServico.Get<Cidade>().ToList();
            dataGridViewList.DataSource = cidades;
            dataGridViewList.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void loadList(DataGridViewRow? linha)
        {
            //aqui deve estar do mesmo jeito que o nome das colunas do datagridview
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            cboEstado.Text = linha?.Cells["Estado"].Value.ToString();
        }
    }
}
