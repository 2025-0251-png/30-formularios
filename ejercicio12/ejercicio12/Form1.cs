using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            var numeros = txtnumeros.Lines
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Select(l => int.Parse(l.Trim())).ToList();

            int pares = numeros.Count(n => n % 2 == 0);
            int impares = numeros.Count - pares;
            int positivos = numeros.Count(n => n > 0);
            int negativos = numeros.Count(n => n < 0);

            txtresultado.Text =
                $"Pares: {pares}\r\nImpares: {impares}\r\nPositivos: {positivos}\r\nNegativos: {negativos}";
        }
    }
}
