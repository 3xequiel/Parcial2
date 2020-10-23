using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parcial2.Camisa c1 = new Camisa(botonpremiun.Checked.Equals(true), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), mangacorta.Checked.Equals(true));

            parcial2.Pantalon p1 = new Pantalon(botonpremiun.Checked.Equals(true), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),bermuda.Checked.Equals(true));

            if (botoncamisa.Checked == true)
            {
                MessageBox.Show("El precio final es" + Convert.ToString(c1.calcularp(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))));
            }
            if (botonpantalon.Checked == true)
            {
                MessageBox.Show("El precio final es" + Convert.ToString(p1.calcularp(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))));
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
