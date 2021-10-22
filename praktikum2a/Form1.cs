using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kali(int a, int b)
        {
            return a * b;
        }

        int tambahlima(ref int a)
        {
            return a+=5;
        }

        void bagidua(float a, out float b)
        {
            b = a / 2;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtbil1.Text);
            b = int.Parse(txtbil2.Text);
            c = kali(a, b);

            txthasilnilai.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c;
            c = int.Parse(txtangka.Text);
            tambahlima(ref c);
            txthasilref.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float c;
            float hasil;

            c = float.Parse(textBox4.Text);
            bagidua(c, out hasil);
            txthasilout.Text = hasil.ToString();
        }
    }
}
