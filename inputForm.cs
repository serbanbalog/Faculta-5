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
    public partial class inputForm : Form
    {
        Button[,] T;
        TextBox Display;
        int max;
        public inputForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            max = 0;
            Display = new TextBox();
            Display.Width = 260;
            Display.Top = 10;
            Display.Left = 10;
            Display.TextAlign = HorizontalAlignment.Right;
            Display.Parent = this;
            Display.ReadOnly = true;
            Display.Font = new Font("Arial", 20, FontStyle.Regular);
            T = new Button[3, 4];

            for(int i = 0; i < 3; i++)
                for(int j = 0; j < 4; j++)
                {
                    T[i, j] = new Button();
                    T[i, j].Parent = this;
                    T[i, j].Size = new Size(80, 85);
                    T[i, j].Location = new Point(i * 90 + 10, 60 + j * 95);
                    int x = i + j * 3;
                    switch (x)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            T[i, j].Text = x.ToString();
                            T[i, j].Font = new Font("Arial", 14, FontStyle.Bold);
                            break;
                        case 10:
                            T[i, j].Text = "Delete";
                            T[i, j].Font = new Font("Arial", 10, FontStyle.Bold);
                            T[i, j].BackColor = Color.Red;
                            break;
                        case 11:
                            T[i, j].Text = "Enter";
                            T[i, j].Font = new Font("Arial", 10, FontStyle.Bold);
                            T[i, j].BackColor = Color.Green;
                            break;
                    }
                    T[i, j].Click += InputButtonClick;
                    T[i, j].Name = x.ToString();
                }
        }

        private void InputButtonClick(object? sender, EventArgs e)
        {
            int x = int.Parse((sender as Button).Name);
            if((max < 4 && x < 10) || (x > 9))
            switch (x)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Display.Text += x.ToString();
                    (sender as Button).Enabled = false;
                    max++;
                    break;
                case 10:
                    for(int i = 0; i < 3; i++)
                        for(int j=0;j<4;j++)
                            T[i, j].Enabled = true;
                    Display.Text = "";
                    max = 0;
                    break;
                case 11:
                        Engine.nu = int.Parse(Display.Text);
                        this.Close();
                    break;
            }
        }

    }
}
