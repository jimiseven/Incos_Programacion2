using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Obtener la dirección IP y el número de subredes desde los TextBox
            string ip = textBoxIP.Text;
            int numSubredes = int.Parse(textBoxNumSubredes.Text);

            // Calcular y mostrar los resultados en el DataGridView
            CalcularSubneteo(ip, numSubredes);
        }

        private void CalcularSubneteo(string ip, int numSubredes)
        {
            // Aquí deberías implementar el cálculo del subneteo
            // Por simplicidad, mostraré un ejemplo de resultado en el DataGridView

            // Limpiar el DataGridView
            dataGridViewResultados.Rows.Clear();

            // Agregar columnas al DataGridView
            dataGridViewResultados.Columns.Clear();
            dataGridViewResultados.Columns.Add("Subred", "Subred");
            dataGridViewResultados.Columns.Add("RangoInicio", "Rango Inicio");
            dataGridViewResultados.Columns.Add("RangoFin", "Rango Fin");

            // Calcular y agregar los rangos de subredes
            for (int i = 0; i < numSubredes; i++)
            {
                string subred = "Subred " + (i + 1);
                string rangoInicio = "192.168." + (i * 10) + ".1";
                string rangoFin = "192.168." + ((i + 1) * 10 - 2) + ".254";

                dataGridViewResultados.Rows.Add(subred, rangoInicio, rangoFin);
            }
        }
    }
}
