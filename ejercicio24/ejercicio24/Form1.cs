using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double c = double.Parse(txtc.Text);

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                txtresultado.Text = "Los lados no forman un triangulo valido.";
                return;
            }

            double sm = (a + b + c) / 2;
            double area = Math.Round(Math.Sqrt(sm * (sm - a) * (sm - b) * (sm - c)), 2);
            txtresultado.Text = "El area es: " + area;
        }
    }
}
