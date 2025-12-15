using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
namespace IFSPStore.App.Base
{
    public partial class BaseForm : MaterialForm
    {
        #region Declarações
        protected bool IsEditMode = false;
        #endregion
        #region Construtor
        public BaseForm()
        {
            InitializeComponent();
            tema();
        }
        #endregion
        private void tema()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            dataGridViewList.DefaultCellStyle.ForeColor = Color.Black;

            
            dataGridViewList.DefaultCellStyle.BackColor = Color.White;
            dataGridViewList.DefaultCellStyle.SelectionForeColor = Color.White; // Texto branco ao selecionar
            dataGridViewList.DefaultCellStyle.SelectionBackColor = Color.Blue;  // Fundo azul ao selecionar
        }
        #region Eventos form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"DriveNow",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
                tabControlRegister.SelectedIndex = 1;
            }

        }
        #endregion
        #region Eventos CRUD
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja relamente deletar esse cadastro?", @"DriveNow",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewList.SelectedRows[0].Cells["Id"].Value;
                    Delete(id);
                    PopulateList();
                }
            }
            else
            {
                MessageBox.Show(@"Por favor seecione uma linha", @"DriveNow",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabPageList_Enter(object sender, EventArgs e)
        {
            PopulateList();
        }
        private void ClearFields()
        {
            IsEditMode = false;
            foreach (var control in tabControlRegister.Controls)
            {
                if (control is ReaLTaiizor.Controls.MaterialTextBoxEdit textBox)
                {
                    textBox.Clear();
                }

                if (control is ReaLTaiizor.Controls.MaterialMaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Clear();
                }

                if (control is ReaLTaiizor.Controls.MaterialComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }

                if (control is ReaLTaiizor.Controls.MaterialSwitch materialSwitch)
                {
                    materialSwitch.Checked = false;
                }
            }
        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void New()
        {
            ClearFields();
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Focus();
        }

        protected virtual void Save()
        {

        }

        protected virtual void Edit()
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                IsEditMode = true;
                var record = dataGridViewList.SelectedRows[0];
                GridToForm(record);
                loadList(record);
                tabControlRegister.SelectedIndex = 0;
                tabControlRegister.Focus();
            }
            else
            {
                MessageBox.Show(@"Por favor seecione uma linha", @"DriveNow",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        protected virtual void loadList(DataGridViewRow? record)
        {

        }
        protected virtual void GridToForm(DataGridViewRow? record)
        {

        }
        protected virtual void Delete(int id)
        {

        }

        protected virtual void PopulateList()
        {
            CarregaGrid();
        }

        #endregion
            
        private void dataGridViewList_CellDoubleClick(object sender, EventArgs e)
        {
            Edit();
        }
        private void tabControlRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlRegister.SelectedIndex == 0) 
            {
                this.AcceptButton = btnSalvar;
            }
            else 
            {
                this.AcceptButton = btnNovo;
            }
        }

        //deletar com a tecla delete
        private void dataGridViewList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
