using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraph
{
    public partial class FormOption : Form
    {
        public FormOption(int x, int y, int t)
        {
            X = x;
            Y = y;
            Thick = t;

            InitializeComponent();
        }

        public int X, Y;
        public int Thick;
        public Color Col1;
        public string ColorName;

        private void FormOption_Load(object sender, EventArgs e)
        {
            tbXaxis.Text = $"{X}";
            tbYaxis.Text = $"{Y}";
            tbThick.Text = $"{Thick}";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult ret = colorDialog1.ShowDialog();
            if(ret==DialogResult.OK)
            {
                Col1 = colorDialog1.Color;
                tbColor.Text = $"{Col1.ToArgb()}";
            }
        }

        private void FormOption_FormClosing(object sender, FormClosingEventArgs e)
        {
            ColorName = tbColor.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            X = int.Parse(tbXaxis.Text);
            Y = int.Parse(tbYaxis.Text);
            Thick = int.Parse(tbThick.Text);
        }
    }
}
