using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            foreach (var linea in txtdatos.Lines.Where(l => !string.IsNullOrWhiteSpace(l)))
            {
                var partes = linea.Split(',');
                double n1 = double.Parse(partes[0].Trim());
                if (n1 == 0) { txtresultado.AppendText("FINAL DEL PROCESO"); break; }

                double n2 = double.Parse(partes[1].Trim());
                txtresultado.AppendText($"suma={n1 + n2}, resta={n1 - n2}, mult={n1 * n2}, " +
                                         $"div={(n2 != 0 ? (n1 / n2).ToString() : "indefinida")}\r\n");
            }
        }
    }
}
