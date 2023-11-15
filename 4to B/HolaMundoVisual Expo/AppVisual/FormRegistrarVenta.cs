using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void ButttonRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    int idVenta = int.Parse(textBoxIdVenta.Text);
                    int numeroCelularVenta = int.Parse(textBoxNumeroCelularVenta.Text);
                    string nombreVenta = textBoxNombreVenta.Text;
                    DateTime fechaInicio = DateTime.Parse(dateTimePickerFechaInicioVenta.Text);
                    DateTime fechaFin = DateTime.Parse(dateTimePickerFechaFinVenta.Text);

                    Venta ventas = new Venta(idVenta, numeroCelularVenta, nombreVenta, fechaInicio, fechaFin);
                    listaVenta.Add(ventas);
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
        }

        private void Limpiar()
        {
            textBoxIdVenta.Text = "";
            textBoxNumeroCelularVenta.Text = "";
            textBoxNombreVenta.Text = "";
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

            // También puedes agregar validaciones específicas para cada campo si es necesario

            return true;
        }
    }
}