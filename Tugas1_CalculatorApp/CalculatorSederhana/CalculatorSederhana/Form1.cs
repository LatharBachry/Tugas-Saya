using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Nilai_1.Text);//*Proses Casting dari String ke Integer
            int b = int.Parse(Nilai_2.Text);
            Double p_Keluaran; // Penyimpanan Sementara untuk Var a & b

            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    p_Keluaran = a + b;
                    Keluaran.Text = Convert.ToString(p_Keluaran);
                    break;
                case 1 :
                    p_Keluaran = a - b;
                    Keluaran.Text = Convert.ToString(p_Keluaran);
                    break;
                case 2 :
                    p_Keluaran = a * b;
                    Keluaran.Text = Convert.ToString(p_Keluaran);
                    break;
                case 3 :
                    p_Keluaran = a / b;
                    Keluaran.Text = Convert.ToString(p_Keluaran);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e) //Fungsi untuk Clear Data
        {
            Nilai_1.Text = "";
            Nilai_2.Text = "";
            Keluaran.Text = "";
        }
    }
}
