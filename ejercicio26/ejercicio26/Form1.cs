using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(txtRadio.Text);
            double pi = Math.PI;

            double longitud = 2 * pi * radio;
            double area = Math.Round(pi * Math.Pow(radio, 2), 2);
            // CORREGIDO: (4.0/3.0) en vez de (4/3), que en C# trunca a 1
            double volumen = Math.Round((4.0 / 3.0) * pi * Math.Pow(radio, 3), 2);

            txtresultado.Text = $"Longitud: {longitud}\r\nArea: {area}\r\nVolumen: {volumen}";
        }
    }
}
