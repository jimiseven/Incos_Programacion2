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

        private void button2Mod_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una fila seleccionada
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                // Recuperamos el índice de la fila seleccionada
                int indiceFilaSeleccionada = dataGridViewUsuarios.SelectedRows[0].Index;

                // Verificamos si el índice es válido
                if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < listaUsuario.Count)
                {
                    // Recuperamos el objeto Usuario en la posición del índice
                    Usuario usuarioSeleccionado = (Usuario)listaUsuario[indiceFilaSeleccionada];

                    // Mostramos los datos en los controles
                    textBoxIdUsuario.Text = usuarioSeleccionado.IdUsuario.ToString();
                    textBoxNombreUsuario.Text = usuarioSeleccionado.NombreUsuario;
                    textBoxNumCelularUsuario.Text = usuarioSeleccionado.NumeroCelularUsuario.ToString();

                    // Guardamos la posición actual para su posterior modificación
                    posicion = indiceFilaSeleccionada;
                }
            }
        }

        private void button1Guar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una posición válida
            if (posicion >= 0 && posicion < listaUsuario.Count)
            {
                try
                {
                    // Modificamos el objeto Usuario en la lista con los nuevos valores
                    Usuario usuarioModificado = new Usuario(
                        int.Parse(textBoxIdUsuario.Text),
                        textBoxNombreUsuario.Text,
                        int.Parse(textBoxNumCelularUsuario.Text)
                    );

                    listaUsuario[posicion] = usuarioModificado;

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
    }
}