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
    public partial class FormRegistrarCuenta : Form
    {
        int posicion;
        ArrayList listaCuenta = new ArrayList();

        public FormRegistrarCuenta()
        {
            InitializeComponent();
        }

        private void ButttonRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    int idCuenta = int.Parse(textBoxIdCuenta.Text);
                    string correoCuenta = textBoxCorreoCuenta.Text;
                    string contraseñaCuenta = textBoxContraseñaCuenta.Text;
                    DateTime fechaCreacionCuenta = DateTime.Parse(dateTimePickerFechaCreacioCuenta.Text);
                    DateTime fechaCargaCuenta = DateTime.Parse(dateTimePickerFechaCargaCuenta.Text);

                    Cuenta cuentas = new Cuenta(idCuenta, correoCuenta, contraseñaCuenta, fechaCreacionCuenta, fechaCargaCuenta);
                    listaCuenta.Add(cuentas);
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
            if (posicion >= 0 && posicion < listaCuenta.Count)
            {
                // Eliminamos el elemento de la lista y actualizamos el DataGridView
                listaCuenta.RemoveAt(posicion);
                ActualizarDataGridView();
                Limpiar();
            }
        }

        private void ActualizarDataGridView()
        {
            // Actualizamos el origen de datos del DataGridView
            dataGridViewCuentas.DataSource = null;
            dataGridViewCuentas.DataSource = listaCuenta;
        }

        private void Limpiar()
        {
            textBoxIdCuenta.Text = "";
            textBoxCorreoCuenta.Text = "";
            textBoxContraseñaCuenta.Text = "";
            dateTimePickerFechaCreacioCuenta.Text = "";
            dateTimePickerFechaCargaCuenta.Text = "";
        }

        private bool ValidarCampos()
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(textBoxIdCuenta.Text) ||
                string.IsNullOrWhiteSpace(textBoxCorreoCuenta.Text) ||
                string.IsNullOrWhiteSpace(textBoxContraseñaCuenta.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerFechaCreacioCuenta.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerFechaCargaCuenta.Text))
            {
                return false;
            }

            // También puedes agregar validaciones específicas para cada campo si es necesario

            return true;
        }
    }
}