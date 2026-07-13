using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horas = double.Parse(Txthoras.Text);
            double tarifa = double.Parse(txttarifa.Text);

            if (horas < 0)
            {
                txtresultado.Text = "Las horas trabajadas no pueden ser negativas.";
                return;
            }

            double salario;
            if (horas <= 40)
                salario = horas * tarifa;
            else
            {
                double horasExtra = horas - 40;
                double tarifaExtra = tarifa * 1.5;
                salario = 40 * tarifa + horasExtra * tarifaExtra;
            }
            txtresultado.Text = "El salario es: " + salario;
        }
    }
}
