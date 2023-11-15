namespace AppVisual
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.panelIzquirda = new System.Windows.Forms.Panel();
            this.buttonSalirProg = new System.Windows.Forms.Button();
            this.panelSubVentasSubMenu = new System.Windows.Forms.Panel();
            this.buttonCuenta = new System.Windows.Forms.Button();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonServicios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPiePag = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonVenta = new System.Windows.Forms.Button();
            this.panelIzquirda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquirda
            // 
            this.panelIzquirda.AutoScroll = true;
            this.panelIzquirda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelIzquirda.Controls.Add(this.buttonSalirProg);
            this.panelIzquirda.Controls.Add(this.panelSubVentasSubMenu);
            this.panelIzquirda.Controls.Add(this.buttonVenta);
            this.panelIzquirda.Controls.Add(this.buttonCuenta);
            this.panelIzquirda.Controls.Add(this.buttonUsuario);
            this.panelIzquirda.Controls.Add(this.buttonCliente);
            this.panelIzquirda.Controls.Add(this.buttonServicios);
            this.panelIzquirda.Controls.Add(this.pictureBox1);
            this.panelIzquirda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquirda.ForeColor = System.Drawing.Color.White;
            this.panelIzquirda.Location = new System.Drawing.Point(0, 0);
            this.panelIzquirda.Name = "panelIzquirda";
            this.panelIzquirda.Size = new System.Drawing.Size(250, 561);
            this.panelIzquirda.TabIndex = 0;
            // 
            // buttonSalirProg
            // 
            this.buttonSalirProg.BackColor = System.Drawing.Color.DimGray;
            this.buttonSalirProg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSalirProg.FlatAppearance.BorderSize = 0;
            this.buttonSalirProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalirProg.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalirProg.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSalirProg.Location = new System.Drawing.Point(0, 578);
            this.buttonSalirProg.Name = "buttonSalirProg";
            this.buttonSalirProg.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.buttonSalirProg.Size = new System.Drawing.Size(233, 38);
            this.buttonSalirProg.TabIndex = 11;
            this.buttonSalirProg.Text = "Salir";
            this.buttonSalirProg.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalirProg.UseVisualStyleBackColor = false;
            this.buttonSalirProg.Click += new System.EventHandler(this.buttonSalirProg_Click);
            // 
            // panelSubVentasSubMenu
            // 
            this.panelSubVentasSubMenu.BackColor = System.Drawing.Color.Gray;
            this.panelSubVentasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubVentasSubMenu.Location = new System.Drawing.Point(0, 503);
            this.panelSubVentasSubMenu.Name = "panelSubVentasSubMenu";
            this.panelSubVentasSubMenu.Size = new System.Drawing.Size(233, 75);
            this.panelSubVentasSubMenu.TabIndex = 10;
            // 
            // buttonCuenta
            // 
            this.buttonCuenta.BackColor = System.Drawing.Color.DimGray;
            this.buttonCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCuenta.FlatAppearance.BorderSize = 0;
            this.buttonCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCuenta.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCuenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCuenta.Location = new System.Drawing.Point(0, 389);
            this.buttonCuenta.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonCuenta.Name = "buttonCuenta";
            this.buttonCuenta.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.buttonCuenta.Size = new System.Drawing.Size(233, 57);
            this.buttonCuenta.TabIndex = 7;
            this.buttonCuenta.Text = "Cuentas";
            this.buttonCuenta.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCuenta.UseVisualStyleBackColor = false;
            this.buttonCuenta.Click += new System.EventHandler(this.buttonCuenta_Click);
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.BackColor = System.Drawing.Color.DimGray;
            this.buttonUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsuario.FlatAppearance.BorderSize = 0;
            this.buttonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUsuario.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUsuario.Location = new System.Drawing.Point(0, 332);
            this.buttonUsuario.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.buttonUsuario.Size = new System.Drawing.Size(233, 57);
            this.buttonUsuario.TabIndex = 5;
            this.buttonUsuario.Text = "Usuarios";
            this.buttonUsuario.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonUsuario.UseVisualStyleBackColor = false;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.DimGray;
            this.buttonCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCliente.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCliente.Location = new System.Drawing.Point(0, 275);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.buttonCliente.Size = new System.Drawing.Size(233, 57);
            this.buttonCliente.TabIndex = 3;
            this.buttonCliente.Text = "Clientes";
            this.buttonCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonServicios
            // 
            this.buttonServicios.BackColor = System.Drawing.Color.DimGray;
            this.buttonServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonServicios.FlatAppearance.BorderSize = 0;
            this.buttonServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonServicios.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServicios.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonServicios.Location = new System.Drawing.Point(0, 218);
            this.buttonServicios.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonServicios.Name = "buttonServicios";
            this.buttonServicios.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.buttonServicios.Size = new System.Drawing.Size(233, 57);
            this.buttonServicios.TabIndex = 1;
            this.buttonServicios.Text = "Servicios";
            this.buttonServicios.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonServicios.UseVisualStyleBackColor = false;
            this.buttonServicios.Click += new System.EventHandler(this.buttonServicios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelPiePag
            // 
            this.panelPiePag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPiePag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPiePag.Location = new System.Drawing.Point(250, 448);
            this.panelPiePag.Name = "panelPiePag";
            this.panelPiePag.Size = new System.Drawing.Size(684, 113);
            this.panelPiePag.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Gray;
            this.panelChildForm.Controls.Add(this.pictureBoxLogo);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 448);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(684, 451);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonVenta
            // 
            this.buttonVenta.BackColor = System.Drawing.Color.DimGray;
            this.buttonVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVenta.FlatAppearance.BorderSize = 0;
            this.buttonVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVenta.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonVenta.Location = new System.Drawing.Point(0, 446);
            this.buttonVenta.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.buttonVenta.Size = new System.Drawing.Size(233, 57);
            this.buttonVenta.TabIndex = 9;
            this.buttonVenta.Text = "Ventas";
            this.buttonVenta.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonVenta.UseVisualStyleBackColor = false;
            this.buttonVenta.Click += new System.EventHandler(this.buttonVenta_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPiePag);
            this.Controls.Add(this.panelIzquirda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "VentanaPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.panelIzquirda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquirda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonServicios;
        private System.Windows.Forms.Button buttonSalirProg;
        private System.Windows.Forms.Panel panelSubVentasSubMenu;
        private System.Windows.Forms.Button buttonCuenta;
        private System.Windows.Forms.Button buttonUsuario;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Panel panelPiePag;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonVenta;

    }
}