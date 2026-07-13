using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horas = double.Parse(txthoras.Text);
            double tarifa = double.Parse(txttarifa.Text);
            txtresultado.Text = "El salario es: " + (horas * tarifa);
        }
    }
}
