using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            if (n < 8) { txtresultado.Text = "Error: N debe ser mayor o igual a 8"; return; }

            int suma = 0;
            for (int x = 8; x <= n; x++) suma += x;
            txtresultado.Text = "La suma es: " + suma;
        }
    }
}
