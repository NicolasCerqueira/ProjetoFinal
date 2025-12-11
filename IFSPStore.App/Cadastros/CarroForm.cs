using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
using System.Globalization;

namespace IFSPStore.App.Cadastros
{
    public partial class CarroForm : BaseForm
    {
        private readonly IBaseService<Carro> _carroServico;
        private readonly IBaseService<Categoria> _categoriaServico;

        private List<CarroModel>? carros;

        public CarroForm(IBaseService<Carro> carroServico, IBaseService<Categoria> categoriaServico)
        {
            _carroServico = carroServico;
            _categoriaServico = categoriaServico;
            InitializeComponent();
            loadCombo();
            txtDataAquisicao.Text = DateTime.Now.ToString("d");
        }

        private void loadCombo()
        {
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.DataSource = _categoriaServico.Get<CategoriaModel>().ToList();
        }

        private void PreencheObject(Carro carro)
        {
            carro.Nome = txtNome.Text;
            carro.Placa = txtPlaca.Text;
            carro.Modelo = cboModelo.Text;
            carro.Marca = txtMarca.Text;
            carro.Cor = txtCor.Text;
            carro.Status = cboStatus.Text;
            carro.Disponivel = switch1.Checked;

            if (int.TryParse(txtAno.Text, out int ano))
            {
                carro.Ano = ano;
            }

            if (decimal.TryParse(txtDiaria.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal preco))
            {
                carro.Diaria = preco;
            }

            if (DateTime.TryParse(txtDataAquisicao.Text, out var dataCompra))
            {
                carro.DataAquisicao = dataCompra;
            }

            if (cboCategoria.SelectedValue != null &&
                int.TryParse(cboCategoria.SelectedValue.ToString(), out int idCategory))
            {
                carro.CategoriaId = idCategory;
                carro.Categoria = null;
            }
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

                //todos os carros do banco 
                var carrosExistentes = _carroServico.Get<Carro>();

                // se existe algum carro com a mesma placa 
                // nao compara o carro com ele mesmo (c.Id != id)
                bool existePlaca = carrosExistentes.Any(c =>
                    c.Placa.Trim().Equals(txtPlaca.Text.Trim(), StringComparison.CurrentCultureIgnoreCase)
                    && c.Id != id);

                if (existePlaca)
                {
                    MessageBox.Show("Já existe um carro cadastrado com esta Placa.", @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Interrompe o salvamento
                }
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var idCarro))
                    {
                        var carro = _carroServico.GetById<Carro>(idCarro);
                        PreencheObject(carro);
                        carro = _carroServico.Update<Carro, Carro, CarroValidator>(carro);
                    }
                }
                else
                {
                    var carro = new Carro();
                    PreencheObject(carro);
                    _carroServico.Add<Carro, Carro, CarroValidator>(carro);
                }
                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
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
                _carroServico.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            carros = _carroServico.Get<CarroModel>(new[] { "Categoria" }).ToList();
            dataGridViewList.DataSource = carros;
            dataGridViewList.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (dataGridViewList.Columns.Contains("CategoriaId"))
                dataGridViewList.Columns["CategoriaId"].Visible = false;
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            if (linha == null) return;

            txtId.Text = linha.Cells["Id"].Value.ToString();
            txtNome.Text = linha.Cells["Nome"].Value.ToString();
            txtDiaria.Text = linha.Cells["Diaria"].Value.ToString();
            txtPlaca.Text = linha.Cells["Placa"].Value?.ToString();
            cboModelo.Text = linha.Cells["Modelo"].Value?.ToString();
            txtAno.Text = linha.Cells["Ano"].Value?.ToString();
            txtCor.Text = linha.Cells["Cor"].Value?.ToString();
            cboStatus.Text = linha.Cells["Status"].Value?.ToString();

            if (linha.Cells["Disponivel"].Value != null)
                switch1.Checked = (bool)linha.Cells["Disponivel"].Value;

            cboCategoria.SelectedValue = linha.Cells["CategoriaId"].Value;

            txtDataAquisicao.Text = DateTime.TryParse(linha.Cells["DataAquisicao"].Value?.ToString(), out var dataC)
               ? dataC.ToString("dd/MM/yyyy")
               : "";
        }
    }
}