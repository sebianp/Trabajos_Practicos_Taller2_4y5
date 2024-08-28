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
            // Validación de los TextBox
            if (string.IsNullOrWhiteSpace(textBoxDesde.Text) || string.IsNullOrWhiteSpace(textBoxHasta.Text))
            {
                MessageBox.Show("Por favor, ingrese los números correctamente en ambos campos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir de la función si los TextBox están vacíos
            }

            // Validación de las CheckBox
            if (!checkBoxPares.Checked && !checkBoxImpares.Checked && !checkBoxPrimos.Checked && !checkBoxTodos.Checked)
            {
                MessageBox.Show("Debe seleccionar al menos una opción (Pares, Impares o Primos) antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir de la función si ninguna CheckBox está seleccionada
            }

            //Extrae los valores de los textBox y los convierte en enteros
            int desde = int.Parse(textBoxDesde.Text);
            int hasta = int.Parse(textBoxHasta.Text);

            
            //Limpia la ListBox antes de generar la nueva lista
            listBoxNumeros.Items.Clear();

            //Limpiar los puntos del gráfico antes de agregar nuevos elementos
            chart1.Series["numeros"].Points.Clear();

            // Título del eje X
            chart1.ChartAreas[0].AxisX.Title = "Orden";

            // Título del eje Y
            chart1.ChartAreas[0].AxisY.Title = "Valor";

            //Crea la lista de números y va agregándolos al ListBox
            while (desde <= hasta)
            {
                //Si el checkBox todos esta activado muestra toda la secuencia
                if (checkBoxTodos.Checked)
                {
                    listBoxNumeros.Items.Add(desde);
                    chart1.Series["numeros"].Points.AddY(desde);

                }

                //Si el checkbox Pares esta activado solo muestra la secuencia de numeros pares
                if(checkBoxPares.Checked && desde % 2 == 0)
                {
                    listBoxNumeros.Items.Add(desde);
                    chart1.Series["numeros"].Points.AddY(desde);
                }

                //Si el checkbox impares esta activado solo muestra la secuencia de numeros impares
                if (checkBoxImpares.Checked && desde % 2 != 0)
                {
                    listBoxNumeros.Items.Add(desde);
                    chart1.Series["numeros"].Points.AddY(desde);
                }

                //Si el checkbox primos esta activado solo muestra la secuencia de numeros primos
                if (checkBoxPrimos.Checked && EsPrimo(desde))
                {
                    listBoxNumeros.Items.Add(desde);
                    chart1.Series["numeros"].Points.AddY(desde);
                }

                desde++;
            }
        }

        private void BNumerosPares_Click(object sender, EventArgs e)
        {
            // Validación de los TextBox
            if (string.IsNullOrWhiteSpace(textBoxDesde.Text) || string.IsNullOrWhiteSpace(textBoxHasta.Text))
            {
                MessageBox.Show("Por favor, ingrese los números correctamente en ambos campos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir de la función si los TextBox están vacíos
            }

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
            // Validación de los TextBox
            if (string.IsNullOrWhiteSpace(textBoxDesde.Text) || string.IsNullOrWhiteSpace(textBoxHasta.Text))
            {
                MessageBox.Show("Por favor, ingrese los números correctamente en ambos campos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir de la función si los TextBox están vacíos
            }

            // Validación de las CheckBox
            if (!checkBoxPares.Checked && !checkBoxImpares.Checked && !checkBoxPrimos.Checked)
            {
                MessageBox.Show("Debe seleccionar al menos una opción (Pares, Impares o Primos) antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir de la función si ninguna CheckBox está seleccionada
            }

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
            chart1.Series["Serie1"].Points.Clear(); // Limpiar los puntos del gráfico antes de agregar nuevos elementos

            //Obtenemos los valores de las textBox y los transformamos en enteros.
            int desde = int.Parse(textBoxDesde.Text);
            int hasta = int.Parse(textBoxHasta.Text);

            while (desde <= hasta)
            {
                if (EsPrimo(desde)) // Verifica si el número es primo
                {
                    listBoxNumeros.Items.Add(desde);
                }
                desde++;
            }
        }

        private bool EsPrimo(int numero)
        {
            //Descartar los números menores o iguales a 1 ya que no son primos.
            if (numero <= 1)
                return false;

            //Tratar el 2 como caso especial, ya que es primo
            if (numero == 2)
                return true;

            //Verificar divisibilidad desde 2 hasta la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                //Si el número es divisible por cualquier i, entonces no es primo.
                if (numero % i == 0)
                    return false;
            }

            // Si no se encuentra ningún divisor, el número es primo.
            return true;
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTodos.Checked)
            {
                checkBoxPares.Checked = false;
                checkBoxImpares.Checked = false;
                checkBoxPrimos.Checked = false;
            }
        }

        private void checkBoxPares_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPares.Checked)
            {
                checkBoxTodos.Checked = false;
                checkBoxImpares.Checked = false;
                checkBoxPrimos.Checked = false;
            }
        }

        private void checkBoxImpares_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxImpares.Checked)
            {
                checkBoxPares.Checked = false;
                checkBoxTodos.Checked = false;
                checkBoxPrimos.Checked = false;
            }
        }

        private void checkBoxPrimos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrimos.Checked)
            {
                checkBoxPares.Checked = false;
                checkBoxImpares.Checked = false;
                checkBoxTodos.Checked = false;
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            //Al presionar BORRAR se limpian todos los textbox y el grafico
            textBoxDesde.Clear();
            textBoxHasta.Clear();
            listBoxNumeros.Items.Clear();

            //Limpiar los puntos del gráfico antes de agregar nuevos elementos
            chart1.Series["numeros"].Points.Clear();

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
