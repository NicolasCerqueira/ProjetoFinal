using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
namespace IFSPStore.App.Cadastros
{
    public partial class CityForm : BaseForm
    {
        private IBaseService<Cidade> _cityService;
        private List<Cidade> cities;
        public CityForm(IBaseService<Cidade> cityService)
        {
            _cityService = cityService;
            InitializeComponent();
        }
        private void preencheObject(Cidade city)
        {
            city.Name = txtName.Text;
            city.State = cboDistrict.Text;
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
                MessageBox.Show(ex.Message, @"IFSP Store",
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
                MessageBox.Show(ex.Message, @"IFSP Store",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            cities = _cityService.Get<Cidade>().ToList();
            dataGridViewList.DataSource = cities;
            dataGridViewList.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void loadList(DataGridViewRow? linha)
        {
            //aqui deve estar do mesmo jeito que o nome das colunas do datagridview
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Name"].Value.ToString();
            cboDistrict.Text = linha?.Cells["State"].Value.ToString();
        }
    }
}
