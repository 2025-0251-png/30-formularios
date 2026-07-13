using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            var lineas = txtdatos.Lines.Where(l => !string.IsNullOrWhiteSpace(l)).Take(10);
            txtresultado.Clear();
            int proceso = 0;
            foreach (var linea in lineas)
            {
                var partes = linea.Split(',');
                double n1 = double.Parse(partes[0].Trim());
                double n2 = double.Parse(partes[1].Trim());
                proceso++;
                txtresultado.AppendText($"Proceso {proceso}: suma={n1 + n2}, resta={n1 - n2}, " +
                                         $"mult={n1 * n2}, div={(n2 != 0 ? (n1 / n2).ToString() : "indefinida")}\r\n");
            }
        }
    }
}
