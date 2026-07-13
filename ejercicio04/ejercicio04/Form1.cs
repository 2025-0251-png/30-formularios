using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int seg = int.Parse(txtsegundos.Text);
            if (seg < 0) { txtresultado.Text = "Debe ser positivo."; return; }
            if (seg == 0) { txtresultado.Text = "0 segundos = 0 minutos."; return; }

            if (seg < 60)
            {
                txtresultado.Text = $"Le faltan {60 - seg} segundos para completar un minuto.";
                return;
            }

            int minutos = seg / 60;
            int sobran = seg % 60;
            txtresultado.Text = $"Equivale a {minutos} minutos, con {sobran} segundos ya transcurridos " +
                                 $"(faltan {60 - sobran} para el siguiente minuto).";
        }
    }
}
