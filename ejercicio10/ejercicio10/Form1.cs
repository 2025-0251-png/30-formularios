using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = Math.Abs(int.Parse(txtnumero.Text));
            int suma = 0;
            while (numero != 0)
            {
                suma += numero % 10;
                numero /= 10;
            }
            txtresultado.Text = "La suma de los digitos es: " + suma;
        }
    }
}
