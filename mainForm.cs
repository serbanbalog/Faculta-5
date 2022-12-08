namespace Faculta_5
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            inputForm myIF = new inputForm();
            myIF.ShowDialog();
        }
    }
}