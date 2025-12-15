using ReaLTaiizor.Forms;

namespace IFSPStore.App.Cadastros
{
    public partial class CalendarioForm : MaterialForm
    {
        public CalendarioForm()
        {
            InitializeComponent();
            monthCalendar1.MinDate = System.DateTime.Today;
        }
        public string DataSelecionada { get; set; }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataSelecionada = monthCalendar1.SelectionStart.ToShortDateString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
