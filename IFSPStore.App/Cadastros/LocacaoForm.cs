using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
using MySqlX.XDevAPI;
using System.Globalization;
using System.Xml.Linq;

namespace IFSPStore.App.Cadastros
{
    public partial class SaleForm : BaseForm
    {
        private void SaleForm_Load(object sender, EventArgs e)
        {

        }
        private List<SaleItemModel> _saleItems = new List<SaleItemModel>();
        private readonly IBaseService<Locacao> _saleService;
        private readonly IBaseService<Funcionario> _userService;
        private readonly IBaseService<Cliente> _customerService;
        private readonly IBaseService<Carro> _productService;
        private readonly IBaseService<Categoria> _categoryService;

        private List<SaleModel>? sales;
        public SaleForm(IBaseService<Locacao> saleService,
                            IBaseService<Funcionario> userService,
                            IBaseService<Cliente> customerService,
                            IBaseService<Carro> productServic,
                            IBaseService<Categoria> categoryService)
        {
           _saleService = saleService;
           _userService = userService;
           _customerService = customerService;
           _productService = productServic;
           _categoryService = categoryService;
           InitializeComponent();
           _saleItems = new List<SaleItemModel>();
           loadCombo();
           CarregaGridItensSale();
           New();
           txtDataLocacao.Text = DateTime.Now.ToString("d");
        }
        private void loadCombo()
        {
           cboFuncionario.ValueMember = "Id";
           cboFuncionario.DisplayMember = "Name";
           cboFuncionario.DataSource = _userService.Get<Funcionario>().ToList();

           cboCliente.ValueMember = "Id";
           cboCliente.DisplayMember = "Nome";
           cboCliente.DataSource = _customerService.Get<Cliente>().ToList();

           cboCarro.ValueMember = "Id";
           cboCarro.DisplayMember = "Name";
           cboCarro.DataSource = _productService.Get<Carro>().ToList();

           cboCategoria.ValueMember = "Id";
           cboCategoria.DisplayMember = "Name";
           cboCategoria.DataSource = _categoryService.Get<Categoria>().ToList();
        }
        private void PreencheObject(Locacao sale)
        {
           if (DateTime.TryParse(txtDataLocacao.Text, out var saleDate))
           {
               sale.SaleDate = saleDate;
           }

           if (cboFuncionario.SelectedValue != null && int.TryParse(cboFuncionario.SelectedValue.ToString(), out var idUser))
           {
               sale.SalesmanId = idUser;
               sale.Salesman = null;
           }

           if (cboCliente.SelectedValue != null && int.TryParse(cboCliente.SelectedValue.ToString(), out var idCustomer))
           {
               sale.CustomerId = idCustomer;
               sale.Customer = null;
           }

           sale.SaleTotal = _saleItems.Sum(x => x.TotalPrice);

           sale.SaleItens.Clear();
           foreach (var item in _saleItems)
           {
               var itemSale = new SaleItem
               {
                   Sale = sale,
                   ProductId = item.IdProduct,
                   Product = null,

                   UnitPrice = item.UnitPrice,
                   Quantity = item.Quantity,
                   TotalPrice = item.TotalPrice
               };

               sale.SaleItens.Add(itemSale);
           }
           CalculateTotalSale(); 
           CarregaGridItensSale();
        }
        protected override void New()
        {
           base.New();
           _saleItems.Clear();
           CarregaGridItensSale();
           txtDataLocacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        protected override void Save()
        {
           try
           {
               if (IsEditMode)
               {
                   if (int.TryParse(txtId.Text, out var id))
                   {
                       var sale = _saleService.GetById<Locacao>(id);
                       PreencheObject(sale);
                       sale = _saleService.Update<Locacao, Locacao, LocacaoValidator>(sale);
                   }
               }
               else
               {
                   var sale = new Locação();
                   PreencheObject(sale);
                   sale = _saleService.Add<Locacao, Locacao, LocacaoValidator>((Locacao)sale);
               }
               CarregaGrid();
               tabControlRegister.SelectedIndex = 1;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
        protected override void Delete(int id)
        {
           try
           {
               _saleService.Delete(id);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
        protected override void CarregaGrid()
        {
           var includes = new List<string>() { "Customer", "Salesman", "SaleItens" };
           sales = _saleService.Get<SaleModel>(includes).ToList();
           dataGridViewList.DataSource = sales;
           dataGridViewList.Columns["IdUser"]!.Visible = false;
           dataGridViewList.Columns["IdCustomer"]!.Visible = false;
           if (dataGridViewList.Columns.Contains("Salesman"))
           {
               dataGridViewList.Columns["Salesman"]!.Visible = false;
           }
           dataGridViewList.Columns["Quantity"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           dataGridViewList.Columns["User"]!.HeaderText = "Salesman";
           dataGridViewList.Columns["SaleTotal"]!.DefaultCellStyle.Format = "C2"; // Formata como moeda
           dataGridViewList.Columns["SaleDate"]!.HeaderText = "Data Venda";
           dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           //dataGridViewList.Columns["Price"].DefaultCellStyle.Format = "C2";
           //dataGridViewList.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        protected override void loadList(DataGridViewRow? linha)
        {
           int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
           txtId.Text = linha?.Cells["Id"].Value.ToString();
           cboFuncionario.SelectedValue = linha?.Cells["IdUser"].Value;
           cboCliente.SelectedValue = linha?.Cells["IdCustomer"].Value;
           txtDataLocacao.Text = DateTime.TryParse(linha?.Cells["SaleDate"].Value.ToString(), out var dataC)
              ? dataC.ToString("g")
              : "";

           var includes = new List<string>() { "Customer", "Salesman", "SaleItens", "SaleItens.Product" };
           var sale = _saleService.GetById<Locacao>(id, includes);
           _saleItems = new List<SaleItemModel>();
           foreach (var item in sale.SaleItens)
           {
               var vendaItem = new SaleItemModel
               {
                   Id = item.Id,
                   IdProduct = item.Product!.Id,
                   Product = item.Product!.Name,
                   TotalPrice = item.TotalPrice,
                   Quantity = item.Quantity,
                   SaleUnit = item.UnitPrice.ToString("N2"),
               };
               _saleItems.Add(vendaItem);
           }
           CarregaGridItensSale();

        }
        private void CarregaGridItensSale()
        {
           var source = new BindingSource();
           source.DataSource = _saleItems.ToArray();
           dataGridViewItens.DataSource = source;
           dataGridViewItens.Columns["Id"]!.Visible = false;
           dataGridViewItens.Columns["IdProduct"]!.HeaderText = @"Id.Product";
           dataGridViewItens.Columns["UnitPrice"]!.DefaultCellStyle.Format = "C2";
           dataGridViewItens.Columns["UnitPrice"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           dataGridViewItens.Columns["TotalPrice"]!.DefaultCellStyle.Format = "C2";
           dataGridViewItens.Columns["TotalPrice"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           dataGridViewItens.Columns["Quantity"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           if (ItemValidator())
           {
               var saleItem = new SaleItemModel();
               if (cboCarro.SelectedValue != null &&
                   int.TryParse(cboCarro.SelectedValue.ToString(), out var idProduct))
               {
                   var product = _productService.GetById<Carro>(idProduct);
                   saleItem.IdProduct = product.Id;
                   saleItem.Product = product.Name;
                   saleItem.SaleUnit = product.SalesUnit;
               }

               if (decimal.TryParse(txtDiarias.Text, out var quantity))
               {
                   saleItem.Quantity = quantity;
               }
               else
               {
                   saleItem.Quantity = 1;
               }

               string precoLimpo = txtPreco.Text.Replace("R$", "").Trim();
               if (decimal.TryParse(precoLimpo, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out var price))
               {
                   saleItem.UnitPrice = price;
               }

               saleItem.TotalPrice = saleItem.Quantity * saleItem.UnitPrice;

               _saleItems.Add(saleItem);

               CarregaGridItensSale();
               CalculateTotalSale();

               txtDiarias.Text = "";
               txtPreco.Text = "";
               txtPrecoTotal.Text = "";
               txtSaleUnit.Text = "";
           }
        }
        private bool ItemValidator()
        {
           return true;
        }
        private void txtVlUnitario_Leave(object sender, EventArgs e)
        {
           if (double.TryParse(txtSaleUnit.Text, out double value))
               txtSaleUnit.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
           else
               txtSaleUnit.Text = string.Empty;

           CalculateTotalItem();
        }
        private void CalculateTotalItem()
        {
           var convVlr = float.TryParse(txtSaleUnit.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float vlUnitario);
           var convQtd = int.TryParse(txtPreco.Text, out int quantidade);
           if (convVlr && convQtd)
           {
               var valorTotal = quantidade * vlUnitario;
               txtPrecoTotal.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
           }
        }
        private void CalculateTotalSale()
        {
           decimal totalVenda = _saleItems.Sum(x => x.TotalPrice);
           lblTotalPrice.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "Valor Total: {0:C2}", totalVenda);

           decimal totalQtd = _saleItems.Sum(x => x.Quantity);
           lblQtdItens.Text = $"Qtd. Produtos: {totalQtd}";
        }
        private void txtQuantity_Leave(object sender, EventArgs e)
        {
           CalculateTotalItem();
        }

        private void cboProduct_SelectedValueChanged(object sender, EventArgs e)
        {
           if (cboCarro.SelectedValue != null)
           {
               var product = (Carro)cboCarro.SelectedItem;

               txtSaleUnit.Text = product.SalesUnit;

               txtPreco.Text = product.Price.ToString("N2");

               cboCategoria.SelectedValue = product.CategoryId;
           }
        }
        private void CalcularTotalItem()
        {
           if (!decimal.TryParse(txtDiarias.Text, out decimal quantidade))
           {
               quantidade = 0;
           }
           string precoLimpo = txtPreco.Text.Replace("R$", "").Trim();

           if (!decimal.TryParse(precoLimpo, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out decimal preco))
           {
               preco = 0;
           }

           decimal total = quantidade * preco;

           txtPrecoTotal.Text = total.ToString("C2");
        }

        private void txtQuantity_Leave_1(object sender, EventArgs e)
        {
           CalcularTotalItem();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
           {
               // Se for letra ou símbolo não escreve nada
               e.Handled = true;
           }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           if (dataGridViewItens.SelectedRows.Count > 0)
           {
               var index = dataGridViewItens.SelectedRows[0].Index;

               _saleItems.RemoveAt(index);
               CarregaGridItensSale();
               CalculateTotalSale();
           }
           else
           {
               MessageBox.Show("Selecione um item para remover.");
           }
        }

    }
}
