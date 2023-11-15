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
    public partial class FormRegistrarUsuario : Form
    {
        int posicion;
        ArrayList listaUsuario = new ArrayList();

        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void ButttonRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    int idUsuario = int.Parse(textBoxIdUsuario.Text);
                    string nombreUsuario = textBoxNombreUsuario.Text;
                    int numeroCelularUsuario = int.Parse(textBoxNumCelularUsuario.Text);

                    Usuario usuarios = new Usuario(idUsuario, nombreUsuario, numeroCelularUsuario);
                    listaUsuario.Add(usuarios);
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
            if (posicion >= 0 && posicion < listaUsuario.Count)
            {
                // Eliminamos el elemento de la lista y actualizamos el DataGridView
                listaUsuario.RemoveAt(posicion);
                ActualizarDataGridView();
                Limpiar();
            }
        }

        private void ActualizarDataGridView()
        {
            // Actualizamos el origen de datos del DataGridView
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = listaUsuario;
        }

        private void Limpiar()
        {
            textBoxIdUsuario.Text = "";
            textBoxNombreUsuario.Text = "";
            textBoxNumCelularUsuario.Text = "";
        }

        private bool ValidarCampos()
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(textBoxIdUsuario.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumCelularUsuario.Text))
            {
                return false;
            }

            // También puedes agregar validaciones específicas para cada campo si es necesario

            return true;
        }
    }
}