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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            //customizeDesing();
        }

        //para ocultar los  paneles de sub menu
        /*private void customizeDesing()
        {
            panelSubServiciosSubMenu.Visible = false;
            panelSubClientesSubMenu.Visible = false;
            panelSubUsuariosSubMenu.Visible = false;
            panelSubCuentasSubMenu.Visible = false;
            panelSubVentasSubMenu.Visible = false;
        }
        //para ocultar sub menus que se muentra antes
        private void hideSubMenu()
        {
            if (panelSubServiciosSubMenu.Visible == true)
                panelSubServiciosSubMenu.Visible = false;
            if (panelSubClientesSubMenu.Visible == true)
                panelSubClientesSubMenu.Visible = false;
            if(panelSubUsuariosSubMenu.Visible == true)
                panelSubUsuariosSubMenu.Visible = false;
            if(panelSubCuentasSubMenu.Visible == true)
                panelSubCuentasSubMenu.Visible = false;
            if(panelSubVentasSubMenu.Visible == true)
                panelSubVentasSubMenu.Visible = false;
        }

        //para mostrar sub menus para poder alternar la visibilidad de los sub menus
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }


        */


        private void buttonServicios_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelSubServiciosSubMenu);
            openChildForm(new FormRegistrarServicio());
        }
        private void buttonRegServ_Click(object sender, EventArgs e)
        {
            //para abrir un formulario especifico
           // openChildForm(new FormRegistrarServicio());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de registro)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonBuscServ_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormBuscarServicio());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de buscar)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonRepServ_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormReportesServicio());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de reportes)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
           // hideSubMenu();
        }
        private void buttonCliente_Click(object sender, EventArgs e)
        {
           // showSubMenu(panelSubClientesSubMenu);
            openChildForm(new FormRegistrarCliente());
        }
        private void buttonRegCli_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormRegistrarCliente());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de registrar)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonBusCli_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormBuscarCliente());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de buscar)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelSubUsuariosSubMenu);
            openChildForm(new FormRegistrarUsuario());
        }
        private void buttonRegUsu_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormRegistrarUsuario());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de registrar)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonBuscUsu_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormBuscarUsuario());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de buscar)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonRepUsu_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormReportesUsuario());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de reportes)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonCuenta_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelSubCuentasSubMenu);
            openChildForm(new FormRegistrarCuenta());
        }
        private void buttonRegCue_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormRegistrarCuenta());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de registrar)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonBuscCue_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormBuscarCuenta());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de buscar)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonRepCue_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReportesCuenta());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de reportes)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelSubVentasSubMenu);
            openChildForm(new FormRegistrarVenta());
        }
        private void buttonRegVen_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormRegistrarVenta());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de registrar)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonBusVen_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormBuscarVenta());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de buscar)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
            //hideSubMenu();
        }
        private void buttonRepVen_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReportesVenta());
            //nuestro codigo para abrir una ventana o algo (en nuestro caso la ventana de reportes)
            //al final de todos los botones usamos esa funcion para ocultar los menus y no se queden abiertos despues de hacer click
           // hideSubMenu();
        }

        // para abrir los formularios dentro el panel central 
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            //VentanaInicio();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalirProg_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }



        //private void buttonCliente_Click(object sender, EventArgs e)
        //{

        //}

       

        

        

        
        

       
    }
}
