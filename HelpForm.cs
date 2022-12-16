using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculta_5
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            List<string> l = new List<string>();
            if (Engine.hCrt == 1)
                l = Engine.h1;
            if(Engine.hCrt == 2)
                l = Engine.h2;
            if(Engine.hCrt == 3)
                l = Engine.h3;
            titleBox.Text = l[0];
            contentBox.Items.Clear();
            for(int i =1;i<l.Count;i++)
            {
                contentBox.Items.Add(l[i]);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Engine.hCrt>1)
            {
                Engine.hCrt--;
                Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Engine.hCrt<2)
            {
                Engine.hCrt++;
                Refresh();
            }
        }
    }
}
