using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace kursach
{
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Addenter_Click(object sender, EventArgs e)
        {
            string l = texlog.Text;
            string p = textBox2.Text;
            string file = "user.txt";
            if (Class1.input(l, p, file) == 1) {
                this.Close();
                thread = new Thread(open);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start(); }
            else {
                MessageBox.Show("Ошибка входа.Неверный логин или пароль!");
            }

        }
        public void open(object obj)
        {
            Application.Run(new Main());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string l = texlog.Text;
            string p = textBox2.Text;
            string file = "user.txt";
            Class1.st(l, p);
            Class1.registre(l, p, file);
            //login.l = texlog.Text;
            // password.p = textBox2.Text;
            MessageBox.Show("Поздравляю вы успешно зарегестрированы");
        }
    }
}
