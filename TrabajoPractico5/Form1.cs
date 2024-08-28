using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Todos los archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Mostrar la ruta en el TextBox
                txtFoto.Text = filePath;

                // Mostrar la imagen en el PictureBox
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length > 0)
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length; // Mover el cursor al final
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla
            }
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length > 0)
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length; // Mover el cursor al final
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {


            //Validar que todos los datos hayan sido ingresados correctamente
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                 string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                 string.IsNullOrWhiteSpace(textBoxSaldo.Text) ||
                 pictureBox1.Image == null ||
                 (!radioButtonHombre.Checked && !radioButtonMujer.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione el sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una nueva fila en el DataGridView
            int rowIndex = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            // Asignar valores a las celdas
            row.Cells["CNombre"].Value = textBoxNombre.Text;
            row.Cells["CApellido"].Value = textBoxApellido.Text;
            row.Cells["CFechaNacimiento"].Value = dateTimeNacimiento.Value.ToShortDateString();
            row.Cells["CSexo"].Value = radioButtonHombre.Checked ? "HOMBRE" : "MUJER";
            row.Cells["CSaldo"].Value = textBoxSaldo.Text;
            row.Cells["CFoto"].Value = pictureBox1.Image;
            row.Cells["CRuta"].Value = txtFoto.Text;

            // Limpiar los campos después de agregar
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            radioButtonHombre.Checked = false;
            radioButtonMujer.Checked = false;
            textBoxSaldo.Clear();
            pictureBox1.Image = null;
            txtFoto.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en la columna del botón "CEliminar"
            if (e.ColumnIndex == dataGridView1.Columns["CEliminar"].Index && e.RowIndex >= 0)
            {
                // Eliminar la fila correspondiente
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtenemos la fila actual
            var row = dataGridView1.Rows[e.RowIndex];

            // Asumiendo que la columna de saldo tiene el nombre "Saldo" y es una columna de tipo decimal o numérico
            decimal saldo = Convert.ToDecimal(row.Cells["CSaldo"].Value);

            // Verificar si el saldo es menor a 50
            if (saldo < 50)
            {
                // Cambiar el color de fondo de la fila a rojo
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White; // Cambiar el color del texto si es necesario
            }
        }
    }
    
}
