using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtmonto.Text);
            if (monto < 0) { txtresultado.Text = "El monto no puede ser negativo."; return; }

            // CORREGIDO: antes era 0.2 (20%), debe ser 0.02 (2%)
            double descuento = monto > 100 ? monto * 0.10 : monto * 0.02;
            txtresultado.Text = $"El monto {monto} tiene un descuento de {descuento}";
        }
    }
}
