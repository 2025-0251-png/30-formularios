using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio20
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

            double disc = b * b - 4 * a * c;

            if (disc > 0)
            {
                double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                double x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                txtresultado.Text = $"x1 = {x1}\r\nx2 = {x2}";
            }
            else if (disc == 0)
            {
                double x = -b / (2 * a);
                txtresultado.Text = "x = " + x;
            }
            else
            {
                double real = -b / (2 * a);
                double imag = Math.Sqrt(-disc) / (2 * a);
                txtresultado.Text = $"x1 = {real} + i({imag})\r\nx2 = {real} - i({imag})";
            }
        }
    }
}
