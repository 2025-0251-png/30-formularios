using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            var notas = txtnotas.Lines
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Select(l => double.Parse(l.Trim())).ToList();

            var aprobadas = notas.Where(n => n >= 10.5).ToList();
            var desaprobadas = notas.Where(n => n < 10.5).ToList();

            txtresultado.Text =
                $"Desaprobadas: {desaprobadas.Count}\r\n" +
                $"Aprobadas: {aprobadas.Count}\r\n" +
                $"Promedio aprobadas: {(aprobadas.Any() ? aprobadas.Average().ToString() : "N/A")}\r\n" +
                $"Promedio desaprobadas: {(desaprobadas.Any() ? desaprobadas.Average().ToString() : "N/A")}\r\n" +
                $"Promedio final: {notas.Average()}";
        }
    }
}
