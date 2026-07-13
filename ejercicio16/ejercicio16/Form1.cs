using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            foreach (char c in txttexto.Text)
            {
                char cl = char.ToLower(c);
                if (cl == 'a' || cl == 'e' || cl == 'i' || cl == 'o' || cl == 'u')
                {
                    txtresultado.Text = "La primera vocal fue: " + c;
                    return;
                }
            }
            txtresultado.Text = "No se ingreso ninguna vocal.";
        }
    }
}
