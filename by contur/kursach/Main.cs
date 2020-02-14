using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursach
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }
        double zakaz=0;
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time=DateTime.Now.ToLongTimeString();
            string time_hour = DateTime.Now.ToShortTimeString();
            richTextBox1.Text = time + "\n";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //textBox1.Text += "2";
            zakaz*=0.8;
            richTextBox2.Text += "К оплате " + zakaz + "\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void button19_DoubleClick(object sender, EventArgs e)
        {
            //textBox1.Text += "000";
            zakaz*=0.8;
            richTextBox2.Text += "К оплате " + zakaz + "\n";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lav=0, meat=0, ing=0,shava=60;
            if (radioButton1.Checked)
                lav = 35;
            if (radioButton2.Checked)
                lav = 25;
            if (radioButton3.Checked)
                lav = 25;
            if (radioButton4.Checked)
                meat = 55;
            if (radioButton5.Checked)
                meat = 65;
            if (radioButton6.Checked)
                meat = 60;
            if (radioButton7.Checked)
                ing = 20;
            if (radioButton8.Checked)
                ing = 15;
            if (radioButton9.Checked)
                ing = 35;
            if (radioButton10.Checked)
                ing = 0;
            shava += lav + meat + ing;
            zakaz += shava;
            richTextBox2.Clear();
            richTextBox2.Text += "К оплате " + zakaz+"\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zakaz += 50;
            richTextBox2.Clear();
            richTextBox2.Text += "К оплате " + zakaz + "\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zakaz += 48;
            richTextBox2.Clear();
            richTextBox2.Text += "К оплате " + zakaz + "\n";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            zakaz += 70;
            richTextBox2.Clear();
            richTextBox2.Text += "К оплате " + zakaz + "\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zakaz += 89;
            richTextBox2.Clear();
            richTextBox2.Text += "К оплате " + zakaz + "\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zakaz += 70;
            richTextBox2.Clear();
            richTextBox2.Text += "К оплате " + zakaz + "\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zakaz += 70;
            richTextBox2.Clear();
            richTextBox2.Text += "К оплате " + zakaz + "\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            zakaz += 70;
            richTextBox2.Clear();
            richTextBox2.Text += "К оплате " + zakaz + "\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zakaz += 70;
            richTextBox2.Clear();
            richTextBox2.Text += "К оплате " + zakaz + "\n";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //string zakaz = richTextBox2.Text;
            //zakaz.Replace("К оплате","");
            string sum = textBox1.Text;
            double op = Convert.ToUInt16(sum);
            //int zak = Convert.ToUInt16(zakaz);
            op = op -zakaz;
            richTextBox2.Clear();
            richTextBox2.Text +="Сдача "+ op + "\n";
            zakaz=0;
        }
    }
}
