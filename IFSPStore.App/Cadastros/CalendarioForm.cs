using ReaLTaiizor.Forms;

namespace IFSPStore.App.Cadastros
{
    public partial class CalendarioForm : MaterialForm
    {

        public CalendarioForm()
        {
            InitializeComponent();
            //LimitadorData();
            //monthCalendar1.MinDate = System.DateTime.Today;
        }
        public string DataSelecionada { get; set; }
        public bool LimitaData { get; set; }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataSelecionada = monthCalendar1.SelectionStart.ToShortDateString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public void LimitadorData()
        {
            if (LimitaData)
            {
                monthCalendar1.MinDate = System.DateTime.Today;
            }
        }
    }
}
