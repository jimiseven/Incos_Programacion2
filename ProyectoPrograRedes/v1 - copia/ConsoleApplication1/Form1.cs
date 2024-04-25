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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de las casillas de texto
            int oct1 = int.Parse(textBox1.Text);
            int oct2 = int.Parse(textBox2.Text);
            int oct3 = int.Parse(textBox3.Text);
            int subRedes = int.Parse(textBox4.Text);

            // Llamar al método en Program.cs
            Program.Calculations(oct1, oct2, oct3, subRedes);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
