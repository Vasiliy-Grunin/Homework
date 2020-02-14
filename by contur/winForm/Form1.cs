using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace winForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string x, y, z;
            x = textBox1.Text;
            y = textBox2.Text;
            z = textBox3.Text;
            Class1.setx(x, y, z);
            textBox5.Clear();
            textBox5.Text += Class1.Mass();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string x, y, z;
            x = textBox1.Text;
            y = textBox2.Text;
            z = textBox3.Text;
            Class1.setx(x, y, z);
            textBox4.Clear();
            textBox4.Text += Class1.Volue();
        }
    }
}
