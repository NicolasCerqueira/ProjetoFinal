using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
using MySqlX.XDevAPI;

namespace IFSPStore.App.Cadastros
{
    public partial class ClienteForm : BaseForm
    {
        private readonly IBaseService<Cliente> _customerService;
        private readonly IBaseService<Cidade> _cityService;

        private List<ClienteModel>? customers;
        public ClienteForm(IBaseService<Cliente> clienteService, IBaseService<Cidade> cidadeService)
        {
            _customerService = clienteService;
            _cityService = cidadeService;
            InitializeComponent();
            loadCombo();
        }
        private void loadCombo()
        {
            cboCity.ValueMember = "Id";
            cboCity.DisplayMember = "Name";
            cboCity.DataSource = _cityService.Get<CidadeModel>().ToList();
        }
        private void preencheObject(Cliente customer)
        {
            customer.Nome = txtNome.Text;
            customer.Endereco = txtEndereco.Text;
            customer.Bairro = txtBairro.Text;
            customer.Documento = txtDocumento.Text;
            if (int.TryParse(cboCity.SelectedValue?.ToString(), out var idCity))
                {
                //var city = _cityService.GetById<City>(idCategory);
                customer.CidadeId = idCity;
                customer.Cidade = null;
                }
        }
        protected override void Save()
        {
            try 
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var customer = _customerService.GetById<Cliente>(id);
                        preencheObject(customer);
                        _customerService.Update<Cliente, Cliente, ClienteValidator>(customer);
                    }
                } else
                {
                    var customer = new Cliente();
                    preencheObject(customer);
                    _customerService.Add<Cliente, Cliente, ClienteValidator>(customer);
                }
                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Delete(int id)
        {
            try 
            {
                _customerService.Delete(id);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            customers = _customerService.Get<ClienteModel>(new[] { "City" }).ToList();
            dataGridViewList.DataSource = customers;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["IdCity"]!.Visible = false;
        }
        protected override void loadList(DataGridViewRow? record)
        {
           txtId.Text = record!.Cells["Id"].Value.ToString();
           txtNome.Text = record.Cells["Name"].Value.ToString();
           txtEndereco.Text = record.Cells["Address"].Value.ToString();
           txtBairro.Text = record.Cells["District"].Value.ToString();
           txtDocumento.Text = record.Cells["Document"].Value?.ToString();
           cboCity.SelectedValue = record.Cells["IdCity"].Value;
        }
    }
}
