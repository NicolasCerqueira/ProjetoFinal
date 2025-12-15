using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;

namespace IFSPStore.App.Cadastros
{
    public partial class CategoriaForm : BaseForm
    {
        private readonly IBaseService<Categoria> _categoriaServico;
        private List<CategoriaModel>? categorias;
        public CategoriaForm(IBaseService<Categoria> categoriaServico)
        {
            _categoriaServico = categoriaServico;
            InitializeComponent();
        }
        private void FormToObject(Categoria categoria)
        {
            categoria.Nome = txtNome.Text;
            categoria.Descricao = txtDescrição.Text;
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

                // Lista de categorias ja cadastradas no banco
                var categoriasExistentes = _categoriaServico.Get<Categoria>();

                // Verifica se existe alguma categoria com o mesmo nome
                bool existeDuplicada = categoriasExistentes.Any(c =>
                    c.Nome.Trim().Equals(txtNome.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) && c.Id != id);

                if (existeDuplicada)
                {
                    MessageBox.Show("Já existe uma categoria cadastrada com este nome.", @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // se tem cat igual nao salva
                }

                if (IsEditMode)
                {
                    var categoria = _categoriaServico.GetById<Categoria>(id);
                    FormToObject(categoria);
                    categoria = _categoriaServico.Update<Categoria, Categoria, CategoriaValidator>(categoria);
                }
                else
                {
                    var categoria = new Categoria();
                    FormToObject(categoria);
                    categoria = _categoriaServico.Add<Categoria, Categoria, CategoriaValidator>(categoria);
                }

                tabControlRegister.SelectedIndex = 1;
                CarregaGrid();
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
                _categoriaServico.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            try
            {
                categorias = _categoriaServico.Get<CategoriaModel>().ToList();
                dataGridViewList.DataSource = categorias;
                //nome ocupa apenas o tamanho do texto
                dataGridViewList.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridViewList.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                dataGridViewList.Columns["Descricao"].HeaderText = "Descrição";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void GridToForm(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtDescrição.Text = linha?.Cells["Descricao"].Value.ToString();
        }
    }
}
