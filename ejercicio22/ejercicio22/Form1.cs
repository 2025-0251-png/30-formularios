using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio22
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
                double numero = double.Parse(linea.Trim());
                if (numero == 0) { txtresultado.AppendText("FINAL DEL PROCESO"); break; }

                double cubo = Math.Pow(numero, 3);
                string raiz = numero >= 0 ? Math.Sqrt(numero).ToString("0.##") : "NaN";
                txtresultado.AppendText($"Numero: {numero}, cubo: {cubo}, raiz: {raiz}\r\n");
            }
        }
    }
}
