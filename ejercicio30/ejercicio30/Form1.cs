using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtnota1.Text);
            double n2 = double.Parse(txtnota2.Text);

            if (n1 < 0 || n1 > 20 || n2 < 0 || n2 > 20)
            {
                txtresultado.Text = "ERROR: las notas deben estar entre 0 y 20";
                return;
            }

            double promedio = (n1 + n2) / 2;
            txtresultado.Text = $"Promedio: {promedio}\r\n" + (promedio >= 10.5 ? "aprobado" : "desaprobado");
        }
    }
}
