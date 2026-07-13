using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(txtprecio.Text);
            double cantidad = double.Parse(txtcantidad.Text);

            double precioVenta = precio * cantidad;
            double iva = Math.Round(precioVenta * 0.15, 2);
            double precioBruto = precioVenta + iva;
            double descuento = precioBruto >= 50 ? Math.Round(precioBruto * 0.05, 2) : 0;
            double total = precioBruto - descuento;

            txtresultado.Text =
                $"Precio de venta: {precioVenta}\r\nIVA: {iva}\r\n" +
                $"Precio bruto: {precioBruto}\r\nDescuento: {descuento}\r\nTotal a pagar: {total}";
        }
    }
}
