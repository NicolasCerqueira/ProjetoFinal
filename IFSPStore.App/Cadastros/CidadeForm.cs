using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
namespace IFSPStore.App.Cadastros
{
    public partial class CidadeForm : BaseForm
    {
        private IBaseService<Cidade> _cityService;
        private List<Cidade> cities;
        public CidadeForm(IBaseService<Cidade> cityService)
        {
            _cityService = cityService;
            InitializeComponent();
        }
        private void preencheObject(Cidade city)
        {
            city.Nome = txtNome.Text;
            city.Estado = cboEstado.Text;
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var city = _cityService.GetById<Cidade>(id);
                       preencheObject(city);
                        city = _cityService.Update<Cidade, Cidade, CidadeValidator>(city);
                    }
                }
                else
                {
                    var city = new Cidade();
                    preencheObject(city);
                    _cityService.Add<Cidade, Cidade, CidadeValidator>(city);

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
                _cityService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            cities = _cityService.Get<Cidade>().ToList();
            dataGridViewList.DataSource = cities;
            dataGridViewList.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void loadList(DataGridViewRow? linha)
        {
            //aqui deve estar do mesmo jeito que o nome das colunas do datagridview
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["ome"].Value.ToString();
            cboEstado.Text = linha?.Cells["Estado"].Value.ToString();
        }
    }
}
