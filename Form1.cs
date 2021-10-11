using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kg = Convert.ToDouble(textBox1.Text);
            double m = Convert.ToDouble(textBox2.Text);
            double vki = kg / (m * m);
            if (vki < 18.49)
            {
                MessageBox.Show("Ideal Kilonun Alti");
            }
            if (vki >= 18.5 && vki <= 24.99)
            {
                MessageBox.Show("Ideal Kilo");
            }
            if (vki >= 25 && vki <= 29.99)
            {
                MessageBox.Show("Ideal Kilonun Uzeri");
            }
            if (vki >= 30)
            {
                MessageBox.Show("Ideal Kilonun Cok Uzeri");
            }  


        }
    }
}
