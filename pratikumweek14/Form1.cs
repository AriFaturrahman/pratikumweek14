using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratikumweek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonreverse_Click(object sender, EventArgs e)
        {
            char[] data = textBoxinput.Text.ToCharArray();
            Array.Reverse(data);
            string kebalik = new string(data);
            labeloutput.Text = kebalik; 
            if (textBoxinput.Text == "")
            {
                MessageBox.Show("harus input terlebih dahulu");
            }
        }

        private void buttonurut_Click(object sender, EventArgs e)
        {
            char[] urut = textBoxinput.Text.ToCharArray();
            Array.Sort(urut);
            string urutan = new string(urut);
            labeloutput.Text = urutan;
            if (textBoxinput.Text == "")
            {
                MessageBox.Show("harus input terlebih dahulu");
            }
        }
    }
}
