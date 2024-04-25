//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace CalculadoraSubneteov5
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void buttonCalcular_Click(object sender, EventArgs e)
//        {
//            // Obtener la dirección IP y el número de subredes desde los TextBox
//            string ip = textBoxIP.Text;
//            int numSubredes = int.Parse(textBoxNumSubredes.Text);

//            // Calcular y mostrar los resultados en el DataGridView
//            CalcularSubneteo(ip, numSubredes);
//        }

//        private void CalcularSubneteo(string ip, int numSubredes)
//        {
//            // Aquí deberías implementar el cálculo del subneteo
//            // Por simplicidad, mostraré un ejemplo de resultado en el DataGridView

//            // Limpiar el DataGridView
//            dataGridViewResultados.Rows.Clear();

//            // Agregar columnas al DataGridView
//            dataGridViewResultados.Columns.Clear();
//            dataGridViewResultados.Columns.Add("Subred", "Subred");
//            dataGridViewResultados.Columns.Add("RangoInicio", "Rango Inicio");
//            dataGridViewResultados.Columns.Add("RangoFin", "Rango Fin");

//            // Calcular y agregar los rangos de subredes
//            for (int i = 0; i < numSubredes; i++)
//            {
//                string subred = "Subred " + (i + 1);
//                string rangoInicio = "192.168." + (i * 10) + ".1";
//                string rangoFin = "192.168." + ((i + 1) * 10 - 2) + ".254";

//                dataGridViewResultados.Rows.Add(subred, rangoInicio, rangoFin);
//            }
//        }

//        private void buttonCalcular_Click_1(object sender, EventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Net;
using System.Windows.Forms;

namespace CalculadoraSubneteo
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridViewResultados;
        private Button buttonCalcular;
        private TextBox textBoxIP;
        private TextBox textBoxNumSubredes;
        private Label labelIP;
        private Label labelNumSubredes;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridViewResultados = new DataGridView();
            this.buttonCalcular = new Button();
            this.textBoxIP = new TextBox();
            this.textBoxNumSubredes = new TextBox();
            this.labelIP = new Label();
            this.labelNumSubredes = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(12, 126);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(360, 150);
            this.dataGridViewResultados.TabIndex = 0;

            this.buttonCalcular.Location = new System.Drawing.Point(297, 97);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 1;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new EventHandler(this.buttonCalcular_Click);

            this.textBoxIP.Location = new System.Drawing.Point(117, 13);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(255, 20);
            this.textBoxIP.TabIndex = 2;

            this.textBoxNumSubredes.Location = new System.Drawing.Point(117, 39);
            this.textBoxNumSubredes.Name = "textBoxNumSubredes";
            this.textBoxNumSubredes.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumSubredes.TabIndex = 3;

            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 16);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(61, 13);
            this.labelIP.TabIndex = 4;
            this.labelIP.Text = "Dirección IP";

            this.labelNumSubredes.AutoSize = true;
            this.labelNumSubredes.Location = new System.Drawing.Point(12, 42);
            this.labelNumSubredes.Name = "labelNumSubredes";
            this.labelNumSubredes.Size = new System.Drawing.Size(99, 13);
            this.labelNumSubredes.TabIndex = 5;
            this.labelNumSubredes.Text = "Número de subredes";

            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelNumSubredes);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.textBoxNumSubredes);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.dataGridViewResultados);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
            // Limpiar el DataGridView
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Columns.Clear();

            // Agregar columnas al DataGridView
            dataGridViewResultados.Columns.Add("Subred", "Subred");
            dataGridViewResultados.Columns.Add("RangoInicio", "Rango Inicio");
            dataGridViewResultados.Columns.Add("RangoFin", "Rango Fin");

            // Convertir la dirección IP a un objeto IPAddress
            IPAddress ipAddress;
            if (!IPAddress.TryParse(ip, out ipAddress))
            {
                MessageBox.Show("Dirección IP inválida");
                return;
            }

            // Obtener la máscara de subred
            byte[] ipBytes = ipAddress.GetAddressBytes();
            int bitsRestantes = 32 - (int)Math.Log(numSubredes, 2);
            int subredSize = 1 << bitsRestantes;
            byte[] subredMask = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                subredMask[i] = (byte)(ipBytes[i] & (255 << bitsRestantes));
            }

            // Calcular los rangos de las subredes
            uint inicioSubred = BitConverter.ToUInt32(ipBytes, 0);
            uint finSubred = BitConverter.ToUInt32(ipBytes, 0);
            for (int i = 0; i < numSubredes; i++)
            {
                inicioSubred = finSubred + 1;
                finSubred = inicioSubred + (uint)(subredSize - 1);
                dataGridViewResultados.Rows.Add("Subred {i + 1}", new IPAddress(BitConverter.GetBytes(inicioSubred)), new IPAddress(BitConverter.GetBytes(finSubred)));
            }
        }
    }
}

