using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
using System.Data;
using System.Linq;

namespace IFSPStore.App.Cadastros
    { 
    public partial class ClienteForm : BaseForm
    {
        private readonly IBaseService<Cliente> _clienteServico;
        private readonly IBaseService<Cidade> _cidadeServico;

        private List<ClienteModel>? customers;
        public ClienteForm(IBaseService<Cliente> clienteServico, IBaseService<Cidade> cidadeServico)
        {
            _clienteServico = clienteServico;
            _cidadeServico = cidadeServico;
            InitializeComponent();
            loadCombo();
        }

        private void loadCombo()
        {
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "Nome";
            cboCidade.DataSource = _cidadeServico.Get<CidadeModel>().ToList();
        }

        private void preencheObject(Cliente cidade)
        {
            cidade.Nome = txtNome.Text;
            cidade.Endereco = txtEndereco.Text;
            cidade.Bairro = txtBairro.Text;
            cidade.Documento = txtDocumento.Text;

            if (int.TryParse(txtCnh.Text, out int cnh))
                cidade.CNH = cnh;
            else
                cidade.CNH = 0;

            if (cboCidade.SelectedValue != null && int.TryParse(cboCidade.SelectedValue.ToString(), out var idCity))
            {
                cidade.CidadeId = idCity;
                cidade.Cidade = null;
            }
        }

        protected override void Save()
        {
            try
            {
                int id = 0;
                if (IsEditMode)
                    int.TryParse(txtId.Text, out id);

                var clientesExistentes = _clienteServico.Get<Cliente>();
                // duplicidade de CNH
                if (int.TryParse(txtCnh.Text, out int cnhDigitada))
                {
                    
                    if (clientesExistentes.Any(c => c.CNH == cnhDigitada && c.Id != id))
                    {
                        MessageBox.Show("Já existe um cliente cadastrado com esta CNH.", @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (clientesExistentes.Any(c => c.Documento == txtDocumento.Text && c.Id != id))
                {
                    MessageBox.Show("Já existe um cliente cadastrado com este CPF.", @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var idCliente))
                    {
                        var cliente = _clienteServico.GetById<Cliente>(idCliente);
                        preencheObject(cliente);
                        _clienteServico.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }
                }
                else
                {
                    var cliente = new Cliente();
                    preencheObject(cliente);
                    _clienteServico.Add<Cliente, Cliente, ClienteValidator>(cliente);
                }

                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _clienteServico.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            customers = _clienteServico.Get<ClienteModel>(new[] { "Cidade" }).ToList();
            dataGridViewList.DataSource = customers;
            dataGridViewList.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["CidadeId"]!.Visible = false;
        }

        protected override void loadList(DataGridViewRow? record)
        {
            if (record == null) return;
            txtId.Text = record.Cells["Id"].Value.ToString();
            txtNome.Text = record.Cells["Nome"].Value.ToString();
            txtEndereco.Text = record.Cells["Endereco"].Value?.ToString();
            txtBairro.Text = record.Cells["Bairro"].Value?.ToString();
            txtDocumento.Text = record.Cells["Documento"].Value?.ToString();

            if (record.Cells["CNH"].Value != null)
                txtCnh.Text = record.Cells["CNH"].Value.ToString();

            cboCidade.SelectedValue = record.Cells["CidadeId"].Value;
        }
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Se for letra ou símbolo não escreve nada
                e.Handled = true;
            }
        }
    }
}