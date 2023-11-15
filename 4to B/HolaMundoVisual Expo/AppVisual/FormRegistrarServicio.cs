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
    public partial class FormRegistrarServicio : Form
    {
        int posicion;
        ArrayList listaServicio = new ArrayList();

        public FormRegistrarServicio()
        {
            InitializeComponent();
        }

        private void ButttonRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    int idServicio = int.Parse(textBoxIdServicio.Text);
                    string nombreServicio = comboBoxServicios.Text;
                    string correoPadre = textBoxCorreoPadre.Text;
                    string contraseñaPadre = textBoxContraseñaPadre.Text;
                    DateTime fechaCreacioServicio = DateTime.Parse(dateTimePickerFechaCreacion.Text);

                    servicios servicio = new servicios(idServicio, nombreServicio, correoPadre, contraseñaPadre, fechaCreacioServicio);
                    listaServicio.Add(servicio);
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
            if (posicion >= 0 && posicion < listaServicio.Count)
            {
                // Eliminamos el elemento de la lista y actualizamos el DataGridView
                listaServicio.RemoveAt(posicion);
                ActualizarDataGridView();
                Limpiar();
            }
        }

        private void ActualizarDataGridView()
        {
            // Actualizamos el origen de datos del DataGridView
            dataGridViewServicios.DataSource = null;
            dataGridViewServicios.DataSource = listaServicio;
        }

        private void Limpiar()
        {
            textBoxIdServicio.Text = "";
            comboBoxServicios.Text = "";
            textBoxCorreoPadre.Text = "";
            textBoxContraseñaPadre.Text = "";
            dateTimePickerFechaCreacion.Text = "";
        }

        private bool ValidarCampos()
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(textBoxIdServicio.Text) ||
                string.IsNullOrWhiteSpace(comboBoxServicios.Text) ||
                string.IsNullOrWhiteSpace(textBoxCorreoPadre.Text) ||
                string.IsNullOrWhiteSpace(textBoxContraseñaPadre.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerFechaCreacion.Text))
            {
                return false;
            }

            return true;
        }

        private void button1Modificar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una fila seleccionada
            if (dataGridViewServicios.SelectedRows.Count > 0)
            {
                // Recuperamos el índice de la fila seleccionada
                int indiceFilaSeleccionada = dataGridViewServicios.SelectedRows[0].Index;

                // Verificamos si el índice es válido
                if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < listaServicio.Count)
                {
                    // Recuperamos el objeto servicios en la posición del índice
                    servicios servicioSeleccionado = (servicios)listaServicio[indiceFilaSeleccionada];

                    // Mostramos los datos en los controles
                    textBoxIdServicio.Text = servicioSeleccionado.IdServicio.ToString();
                    comboBoxServicios.Text = servicioSeleccionado.NombreServicio;
                    textBoxCorreoPadre.Text = servicioSeleccionado.CorreoPadre;
                    textBoxContraseñaPadre.Text = servicioSeleccionado.ContraseñaPadre;
                    dateTimePickerFechaCreacion.Text = servicioSeleccionado.FechaCreacioServicio.ToString();

                    // Guardamos la posición actual para su posterior modificación
                    posicion = indiceFilaSeleccionada;
                }
            }
        }

        private void labelVisualServicio_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Verificamos si hay una posición válida
        if (posicion >= 0 && posicion < listaServicio.Count)
        {
            try
            {
                // Modificamos el objeto servicios en la lista con los nuevos valores
                servicios servicioModificado = new servicios(
                    int.Parse(textBoxIdServicio.Text),
                    comboBoxServicios.Text,
                    textBoxCorreoPadre.Text,
                    textBoxContraseñaPadre.Text,
                    DateTime.Parse(dateTimePickerFechaCreacion.Text)
                );

                listaServicio[posicion] = servicioModificado;

                ActualizarDataGridView();

                // Limpiar las casillas automaticamente, despues de cargar los nuevos datos
                Limpiar();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Por favor, ingrese datos válidos en los campos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
        }


    }
}