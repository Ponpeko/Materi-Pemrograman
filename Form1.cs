using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorMachine;

namespace CalculatorWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nilaiA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtnilaiA.Text);
            var b = int.Parse(txtnilaiB.Text);

            var cal = new Calculator();
           
            listHasil.Items.Clear();
            listHasil.Items.Add(string.Format("Penjumlahan {0} + {1} = {2}", a, b, cal.Penjumlahan(a,b)));
            listHasil.Items.Add(string.Format("Pengurangan {0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            listHasil.Items.Add(string.Format("Perkalian {0} * {1} = {2}", a, b, cal.Perkalian(a, b)));
            listHasil.Items.Add(string.Format("Pembagian {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b)));
            listHasil.Items.Add(string.Format("Pangkat {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b)));
            listHasil.Items.Add(string.Format("Pembagian {0} % {1} = {2}", a, b, Calculator.Modulo(a, b)));
        }
    }
}