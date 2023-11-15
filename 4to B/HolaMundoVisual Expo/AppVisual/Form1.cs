using System;
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
    public partial class VentanaInicio : Form
    {
        string usuario = "admin";
        string contrasenia = "admin"; 
        
        public VentanaInicio()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string usuarioTexBox = this.textBoxUsuario.Text;
            string contraseniaTexBox = this.textBoxContraseña.Text;
            if (usuarioTexBox == usuario && contraseniaTexBox == contrasenia)
            {
                VentanaPrincipal venPrincipal = new VentanaPrincipal();
                venPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos, vuelve a ingresar los datos.");
                this.labelError.Visible = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in panelPrincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.Black;
                }
            }
        }

        private void label1_Leave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in panelPrincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.White;
                }
            }
        }

        private void txtEnter(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in panelSop.Controls)
            {
                if (ctr is Panel && ctr.Name == "panel" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }

        private void txtLeave(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in panelSop.Controls)
            {
                if (ctr is Panel && ctr.Name == "panel" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Silver;
                }
            }
        }

        

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private bool controlTimer = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!controlTimer)
            {
                panelContenedor.Left += 10;
                panelSop.BringToFront();
                if (panelContenedor.Left == 400)
                {
                    timer1.Stop();
                    controlTimer = true;
                }
            }
            else 
            {
                panelContenedor.Left  -=10;
                panelIniSes.BringToFront();
                if (panelContenedor.Left ==0)
                {
                    timer1.Stop();
                    controlTimer = false;
                }
            }
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos fueron enviados correctamente.");
            this.labelError.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /*private void pictureBoxSuperior_Click(object sender, EventArgs e)
        {

        }*/
    }
}
