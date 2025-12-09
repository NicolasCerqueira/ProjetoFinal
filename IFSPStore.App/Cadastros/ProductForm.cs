using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;

namespace IFSPStore.App.Cadastros
{
    public partial class ProductForm : BaseForm
    {
        private readonly IBaseService<Carro> _productService;
        private readonly IBaseService<Categoria> _categoryService;

        private List<Models.testeModel>? products;
        public ProductForm(IBaseService<Carro> productService, IBaseService<Categoria> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            InitializeComponent();
            loadCombo();
            txtSaleDate.Text = DateTime.Now.ToString("d");
        }
        private void loadCombo()
        {
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";
            cboCategory.DataSource = _categoryService.Get<CategoriaModel>().ToList();
        }

        private void PreencheObject(Carro product)
        {
            product.Name = txtName.Text;
            if (decimal.TryParse(txtPrice.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out decimal price))
            {
                product.Price = price;
            }

            if (DateTime.TryParse(txtSaleDate.Text, out var dataCompra))
            {
                product.PurchaseDate = dataCompra;
            }
            product.SalesUnit = txtSaleUnit.Text;
            if (int.TryParse(txtQuantity.Text, out var quantity))
            {
                product.Quantity = quantity;
            }

            if (cboCategory.SelectedValue != null && 
                int.TryParse(cboCategory.SelectedValue.ToString(), out int idCategory))
            {
                //var category = _categoryService.GetById<Category>(idCategory);
                //product.Category = category;
                product.CategoryId = idCategory;
                product.Category = null;

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
                        var product = _productService.GetById<Carro>(id);
                        PreencheObject(product);
                        product = _productService.Update<Carro, Carro, CarroValidator>(product);
                    }
                }
                else
                {
                    var product = new Carro();
                    PreencheObject(product);
                    _productService.Add<Carro, Carro, CarroValidator>(product);

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
                _productService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            products = _productService.Get<Locacao>(new[] { "Category" }).ToList();
            dataGridViewList.DataSource = products;
            dataGridViewList.Columns["IdCategory"]!.Visible = false;
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Name"].Value.ToString();
            txtSaleUnit.Text = linha?.Cells["SalesUnit"].Value.ToString();
            txtPrice.Text = linha?.Cells["Price"].Value.ToString();
            cboCategory.SelectedValue = linha?.Cells["Category"].Value;
            txtSaleDate.Text = DateTime.TryParse(linha?.Cells["PurchaseDate"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";

        }

    }
}
