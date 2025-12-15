using ReaLTaiizor.Forms;

namespace IFSPStore.App.Cadastros
{
    public partial class CalendarioForm : MaterialForm
    {
        public CalendarioForm()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDataLocacao.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
    }
}
