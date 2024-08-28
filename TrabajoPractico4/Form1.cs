using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxDesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void textBoxHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BGenerar_Click(object sender, EventArgs e)
        {
            //Extrae los valores de los textBox y los convierte en enteros
            int desde = int.Parse(textBoxDesde.Text);
            int hasta = int.Parse(textBoxHasta.Text);

            //Limpia la ListBox antes de generar la nueva lista
            listBoxNumeros.Items.Clear();

            //Crea la lista de números y va agregándolos al ListBox
            while (desde <= hasta)
            {
                listBoxNumeros.Items.Add(desde);
                desde++;
            }
        }

        private void BNumerosPares_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear(); //Limpia la ListBox

            //Obtenemos los valores de las textBox y los transformamos en enteros.
            int desde = int.Parse(textBoxDesde.Text);
            int hasta = int.Parse(textBoxHasta.Text);

            while (desde <= hasta)
            {
                if (desde % 2 == 0 && desde != 0) // Verificar si el número es par
                {
                    listBoxNumeros.Items.Add(desde);
                }
                desde++;
            }
        }

        private void BNumerosImpares_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear(); //Limpia la ListBox

            //Obtenemos los valores de las textBox y los transformamos en enteros.
            int desde = int.Parse(textBoxDesde.Text);
            int hasta = int.Parse(textBoxHasta.Text);

            while (desde <= hasta)
            {
                if (desde % 2 != 0 && desde != 0) // Verificar si el número es par
                {
                    listBoxNumeros.Items.Add(desde);
                }
                desde++;
            }
        }

        private void BNumerosPrimos_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear(); //Limpia la ListBox

            //Obtenemos los valores de las textBox y los transformamos en enteros.
            int desde = int.Parse(textBoxDesde.Text);
            int hasta = int.Parse(textBoxHasta.Text);

        }
    }
}
