using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txtminutos.Text);
            if (t < 0) { txtresultado.Text = "No puede ser negativo."; return; }

            int dias = t / 1440;
            int resto = t % 1440;
            int horas = resto / 60;
            int minutos = resto % 60;
            txtresultado.Text = $"{dias} dias, {horas} horas, {minutos} minutos";
        }
    }
}
