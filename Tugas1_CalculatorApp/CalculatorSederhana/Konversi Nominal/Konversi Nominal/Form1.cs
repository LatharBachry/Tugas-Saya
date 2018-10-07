using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KonversiLibrary;

namespace Konversi_Nominal
{
    public partial class Form1 : Form
    {
        Koversi terbilang = new Koversi();//
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(nominal.Text);
            richTextBox1.Text = Convert.ToString(terbilang.TerbilangIndonesia(a));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nominal.Text = "";
            richTextBox1.Text = "";
        }
    }
}
