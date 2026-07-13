using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            var lineas = txtdatos.Lines; 
            double sumaTotal = 0;
            int trabajador = 0;
            txtresultado.Clear();

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var partes = linea.Split(',');
                trabajador++;
                double horas = double.Parse(partes[0].Trim());
                double tarifa = double.Parse(partes[1].Trim());
                double salario = horas * tarifa;
                sumaTotal += salario;
                txtresultado.AppendText($"Trabajador {trabajador}: {salario}\r\n");
            }
            txtresultado.AppendText($"\r\nSuma total: {sumaTotal}");
        }
    }
}
