using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtn.Text);
            int suma = 0;
            txtresultado.Clear();
            for (int x = 1; x <= n; x++)
            {
                suma += x;
                txtresultado.AppendText($"n{x}: {x}\r\n");
            }
            txtresultado.AppendText($"\r\nLa suma es: {suma}");
        }
    }
}
