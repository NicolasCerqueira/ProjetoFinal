using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;

namespace IFSPStore.App.Cadastros
{
    public partial class CategoriaForm : BaseForm
    {
        private readonly IBaseService<Categoria> _categoryService;
        private List<CategoriaModel>? categories;
        public CategoriaForm(IBaseService<Categoria> categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
        }
        private void FormToObject(Categoria category)
        {
            category.Nome = txtNome.Text;
            category.Descricao = txtDescrição.Text;
        }
        protected override void Save()
        {
            try {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var category = _categoryService.GetById<Categoria>(id);
                    FormToObject(category);
                    category = _categoryService.Update<Categoria, Categoria,
                        CategoriaValidator>(category);
                } else
                {
                    var category = new Categoria();
                    FormToObject(category);
                    category = _categoryService.Add<Categoria, Categoria, CategoriaValidator>(category);
                }
                tabControlRegister.SelectedIndex = 1;
                CarregaGrid();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _categoryService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            try
            {
                categories = _categoryService.Get<CategoriaModel>().ToList();
                dataGridViewList.DataSource = categories;
                dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtNome.Text = record?.Cells["Name"].Value.ToString();
            txtDescrição.Text = record?.Cells["Description"].Value.ToString();
        }
    }
}
