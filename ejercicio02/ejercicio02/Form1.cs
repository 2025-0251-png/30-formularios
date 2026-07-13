using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double sueldo = double.Parse(txtsueldo.Text);
            if (sueldo < 0) { txtresultado.Text = "El sueldo no puede ser negativo."; return; }

            double descuento;
            if (sueldo <= 1000)
                descuento = sueldo * 0.10;
            else if (sueldo <= 2000)
                descuento = (sueldo - 1000) * 0.05 + 1000 * 0.10;
            else
                descuento = (sueldo - 2000) * 0.03 + 1000 * 0.05 + 1000 * 0.10;

            double neto = sueldo - descuento;
            txtresultado.Text = $"Descuento: {descuento}\r\nSueldo neto: {neto}";
        }
    }
}
