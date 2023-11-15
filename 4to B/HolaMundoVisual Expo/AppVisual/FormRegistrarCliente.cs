using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppVisual
{
    public partial class FormRegistrarCliente : Form
    {
        int posicion;
        ArrayList listaClientes = new ArrayList();

        public FormRegistrarCliente()
        {
            InitializeComponent();
        }

        private void ButttonRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    int idCliente = int.Parse(textBoxIdCliente.Text);
                    string nombreCliente = textBoxNombre.Text;
                    int numeroCelularCliente = int.Parse(textBoxNumCelular.Text);

                    Cliente cliente = new Cliente(idCliente, nombreCliente, numeroCelularCliente);
                    listaClientes.Add(cliente);
                    ActualizarDataGridView();
                    Limpiar();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Por favor, ingrese datos válidos en los campos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Por favor, complete todos los campos antes de registrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una fila seleccionada
            if (posicion >= 0 && posicion < listaClientes.Count)
            {
                // Eliminamos el elemento de la lista y actualizamos el DataGridView
                listaClientes.RemoveAt(posicion);
                ActualizarDataGridView();
                Limpiar();
            }
        }

        private void ActualizarDataGridView()
        {
            // Actualizamos el origen de datos del DataGridView
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = listaClientes;
        }

        private void Limpiar()
        {
            textBoxIdCliente.Text = "";
            textBoxNombre.Text = "";
            textBoxNumCelular.Text = "";
        }

        private bool ValidarCampos()
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(textBoxIdCliente.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumCelular.Text))
            {
                return false;
            }

            // También puedes agregar validaciones específicas para cada campo si es necesario

            return true;
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Actualizamos la posición al hacer clic en una celda
            posicion = dataGridViewClientes.CurrentRow.Index;
            // Mostramos los datos en los TextBox correspondientes
            textBoxIdCliente.Text = dataGridViewClientes[1, posicion].Value.ToString();
            textBoxNombre.Text = dataGridViewClientes[2, posicion].Value.ToString();
            textBoxNumCelular.Text = dataGridViewClientes[3, posicion].Value.ToString();
        }

        private void buttonImprimir_Click(object sender, System.EventArgs e)
        {
            /*
             SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + "pdf";
            guardar.ShowDialog();
             */
            // Verificamos si hay datos antes de intentar imprimir
            if (listaClientes.Count > 0)
            {
                // Creamos una cadena que contendrá el contenido del informe
                StringBuilder reporte = new StringBuilder();

                // Título del informe
                reporte.AppendLine("Informe de Clientes");

                // Contenido del informe
                foreach (Cliente cliente in listaClientes)
                {
                    // Convertimos los datos del cliente a una cadena para mostrarlos en el informe
                    string clienteInfo = "ID: {cliente.IdCliente}, Nombre: {cliente.Nombre}, Celular: {cliente.NumeroCelular}";

                    // Agregamos la información del cliente al informe
                    reporte.AppendLine(clienteInfo);
                }

                // Guardamos el contenido del informe en un archivo PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Agregamos la extensión ".pdf" si no está presente
                    string filePath = saveFileDialog.FileName.EndsWith(".pdf") ? saveFileDialog.FileName : saveFileDialog.FileName + ".pdf";

                    // Escribimos el contenido en el archivo
                    File.WriteAllText(filePath, reporte.ToString());

                    MessageBox.Show("Informe generado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Error: No hay datos para generar el informe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
