using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double caja = 371; 
            var egresos = txtEgresos.Lines.Where(l => !string.IsNullOrWhiteSpace(l))
                .Select(l => double.Parse(l.Trim()));

            double total = egresos.Sum();
            txtresultado.Text = $"Total de egresos: {total}\r\nQueda en caja: {caja - total}";
        }
    }
}
