using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;


namespace AppVisual
{
    public partial class FormRegistrarVenta : Form
    {
        ArrayList listaVenta = new ArrayList();
        int posicion;

        public FormRegistrarVenta()
        {
            InitializeComponent();
        }

        public void ButttonRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    int idVenta = int.Parse(textBoxIdVenta.Text);
                    int numeroCelularVenta = int.Parse(textBoxNumeroCelularVenta.Text);
                    string nombreVenta = textBoxNombreVenta.Text;
                    int precioVenta = int.Parse(textBox1.Text);
                    string servicio = comboBox2.Text;
                    DateTime fechaInicio = DateTime.Parse(dateTimePickerFechaInicioVenta.Text);
                    DateTime fechaFin = DateTime.Parse(dateTimePickerFechaFinVenta.Text);

                    int dias = (fechaInicio - fechaFin).Days;

                    Venta ventas = new Venta(idVenta, numeroCelularVenta, precioVenta, nombreVenta, servicio, fechaInicio, fechaFin);
                    listaVenta.Add(ventas);
                    ActualizarDataGridView();
                    Limpiar();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Por favor, ingrese datos válidos en los campos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
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
            if (posicion >= 0 && posicion < listaVenta.Count)
            {
                // Eliminamos el elemento de la lista y actualizamos el DataGridView
                listaVenta.RemoveAt(posicion);
                ActualizarDataGridView();
                Limpiar();
            }
        }

        private void ActualizarDataGridView()
        {
            // Actualizamos el origen de datos del DataGridView
            dataGridViewVentas.DataSource = null;
            dataGridViewVentas.DataSource = listaVenta;


            // Agregamos la columna "Dias" solo si no existe
            if (!dataGridViewVentas.Columns.Contains("Dias"))
            {
                dataGridViewVentas.Columns.Add("Dias", "Días");
                dataGridViewVentas.Columns["Dias"].DataPropertyName = "Dias";
            }

            // Actualizamos los valores de la columna "Dias"
        }

        private void Limpiar()
        {
            textBoxIdVenta.Text = "";
            textBoxNumeroCelularVenta.Text = "";
            textBoxNombreVenta.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            dateTimePickerFechaInicioVenta.Text = "";
            dateTimePickerFechaFinVenta.Text = "";
        }

        private bool ValidarCampos()
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(textBoxIdVenta.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumeroCelularVenta.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombreVenta.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerFechaInicioVenta.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerFechaFinVenta.Text))
            {
                return false;
            }

            // Validar que el número de celular esté en el rango especificado
            if (!EsNumeroCelularValido(int.Parse(textBoxNumeroCelularVenta.Text)))
            {
                MessageBox.Show("El número de celular debe estar entre 60000000 y 79999999.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // También puedes agregar validaciones específicas para cada campo si es necesario

            return true;
        }

        private bool EsNumeroCelularValido(int numeroCelular)
            {
                // Verificar si el número de celular es un número válido y está en el rango especificado
                if (numeroCelular > 60000000 && numeroCelular <= 79999999)
                {
                    return true;
                }

                return false;
            }


        private void button2Mod_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una fila seleccionada
            if (dataGridViewVentas.SelectedRows.Count > 0)
            {
                // Recuperamos el índice de la fila seleccionada
                int indiceFilaSeleccionada = dataGridViewVentas.SelectedRows[0].Index;

                // Verificamos si el índice es válido
                if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < listaVenta.Count)
                {
                    // Recuperamos el objeto Venta en la posición del índice
                    Venta ventaSeleccionada = (Venta)listaVenta[indiceFilaSeleccionada];

                    // Mostramos los datos en los controles
                    textBoxIdVenta.Text = ventaSeleccionada.IdVenta.ToString();
                    textBoxNumeroCelularVenta.Text = ventaSeleccionada.NumeroCelularVenta.ToString();
                    textBoxNombreVenta.Text = ventaSeleccionada.NombreVenta;
                    comboBox2.Text = ventaSeleccionada.Servicio;
                    textBox1.Text = ventaSeleccionada.precioVenta.ToString();
                    dateTimePickerFechaInicioVenta.Text = ventaSeleccionada.FechaInicio.ToString();
                    dateTimePickerFechaFinVenta.Text = ventaSeleccionada.FechaFin.ToString();

                    // Guardamos la posición actual para su posterior modificación
                    posicion = indiceFilaSeleccionada;
                }
            }
        }

        private void button1Guar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una posición válida
            if (posicion >= 0 && posicion < listaVenta.Count)
            {
                try
                {
                    
                    // Modificamos el objeto Venta en la lista con los nuevos valores
                    Venta ventaModificada = new Venta(
                        int.Parse(textBoxIdVenta.Text),
                        int.Parse(textBoxNumeroCelularVenta.Text),
                        int.Parse(textBox1.Text),
                        comboBox2.Text,
                        textBoxNombreVenta.Text,
                        DateTime.Parse(dateTimePickerFechaInicioVenta.Text),
                        DateTime.Parse(dateTimePickerFechaFinVenta.Text)
                    );

                    listaVenta[posicion] = ventaModificada;

                    // Actualizamos el DataGridView
                    ActualizarDataGridView();

                    // Limpiamos los controles
                    Limpiar();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Por favor, ingrese datos válidos en los campos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
    }
        }

        private void button1Rep_Click(object sender, EventArgs e)
        {
            
        }

        private void button1B_Click(object sender, EventArgs e)
        {
            // Obtener el número de celular a buscar desde el cuadro de texto
            string numeroCelularABuscar = textBoxNumeroCelularVenta.Text;

            // Validar que el número de celular no esté vacío
            if (!string.IsNullOrWhiteSpace(numeroCelularABuscar))
            {
                // Buscar el número de celular en la lista de ventas
                Venta ventaEncontrada = BuscarVentaPorNumeroCelular(numeroCelularABuscar);

                if (ventaEncontrada != null)
                {
                    // Mostrar la venta encontrada o realizar las acciones que desees
                    MessageBox.Show("Venta encontrada: {ventaEncontrada.NombreVenta}", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna venta con el número de celular especificado.", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de celular para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Venta BuscarVentaPorNumeroCelular(string numeroCelular)
            {
                // Iterar sobre la lista de ventas y buscar por número de celular
                foreach (Venta venta in listaVenta)
                {
                    if (venta.NumeroCelularVenta.ToString() == numeroCelular)
                    {
                        return venta;
                    }
                }

                // Si no se encuentra ninguna venta con el número de celular especificado, devolver null
                return null;
            }
         }
}