using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int suma = 0;
            long producto = 1;
            for (int x = 20; x <= 30; x += 2)
            {
                suma += x;
                producto *= x;
            }
            txtresultado.Text = $"Suma: {suma}\r\nProducto: {producto}";
        }
    }
}
