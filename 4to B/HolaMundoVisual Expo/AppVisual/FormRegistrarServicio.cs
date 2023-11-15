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

            // También puedes agregar validaciones específicas para cada campo si es necesario

            return true;
        }
    }
}