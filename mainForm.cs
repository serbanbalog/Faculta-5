using System.Security.Cryptography.X509Certificates;

namespace Faculta_5
{
    public partial class mainForm : Form
    {
        ListBox listBox;
        public mainForm()
        {
            InitializeComponent();

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            inputForm myIF = new inputForm();
            myIF.ShowDialog();

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            listBox = new ListBox();
            listBox.Width = 90;
            listBox.Height = 500;
            listBox.Top = 50;
            listBox.Left = 10;
            listBox.Parent = this;
            listBox.Font = new Font("Arial", 20, FontStyle.Regular);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            listBox.Items.Add(Engine.x.ToString());

        }
    }
}