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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int oct1, subRedes;
            oct1 = int.Parse(textBox1.Text);
            subRedes = int.Parse(textBox2.Text);

            int bits = 0;
            int indS = 0;
            do
            {
                // Calcular inds
                indS = (int)Math.Pow(2, bits) - 2;

                // Verificar si inds es igual o mayor a subRedes
                if (indS >= subRedes)
                {

                    break; // Salir del bucle
                }

                // Incrementar bits
                bits++;

            } while (true);
            int saltos = 256 / ((int)Math.Pow(2, bits));

            string clase;

            if (oct1 >= 0 && oct1 <= 127)
            {
                clase = "Clase A";
            }
            else if (oct1 >= 128 && oct1 <= 191)
            {
                clase = "Clase B";
            }
            else if (oct1 >= 192 && oct1 <= 256)
            {
                clase = "Clase C";
            }
            else
            {
                clase = "Fuera de rango";
            }

            int masc = 0;
            if (clase == "Clase A")
            {
                masc = 8 + bits;
            }
            else if (clase == "Clase B")
            {
                masc = 16 + bits;
            }
            else if (clase == "Clase C")
            {
                masc = 24 + bits;
            }

            textBox3.Text = bits.ToString();
            //data
        }
    }
}
