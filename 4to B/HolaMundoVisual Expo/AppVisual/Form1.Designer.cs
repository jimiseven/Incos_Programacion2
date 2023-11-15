namespace AppVisual
{
    partial class VentanaInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInicio));
            this.labelProblemas = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.labelMensajeAccedere = new System.Windows.Forms.Label();
            this.labelIniciarSecion = new System.Windows.Forms.Label();
            this.labelMensajeProblema = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelIniSes = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelContra = new System.Windows.Forms.Panel();
            this.pUsuario = new System.Windows.Forms.Panel();
            this.panelSop = new System.Windows.Forms.Panel();
            this.panelContraseñaSop = new System.Windows.Forms.Panel();
            this.labelContraSop = new System.Windows.Forms.Label();
            this.textBoxConstraSop = new System.Windows.Forms.TextBox();
            this.panelUsuarioSop = new System.Windows.Forms.Panel();
            this.labelUsuarioSop = new System.Windows.Forms.Label();
            this.textBoxUsuarioSop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCorreoSop = new System.Windows.Forms.Panel();
            this.labelCorreoSop = new System.Windows.Forms.Label();
            this.textBoxCorreoSop = new System.Windows.Forms.TextBox();
            this.panelNombreSop = new System.Windows.Forms.Panel();
            this.labelNombreSop = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNombreSop = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelIniSes.SuspendLayout();
            this.panelSop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProblemas
            // 
            this.labelProblemas.AutoSize = true;
            this.labelProblemas.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProblemas.ForeColor = System.Drawing.Color.White;
            this.labelProblemas.Location = new System.Drawing.Point(470, 48);
            this.labelProblemas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProblemas.Name = "labelProblemas";
            this.labelProblemas.Size = new System.Drawing.Size(266, 64);
            this.labelProblemas.TabIndex = 0;
            this.labelProblemas.Text = "¿Tienes problemas\r\n para iniciar secion?";
            this.labelProblemas.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.Black;
            this.labelUsuario.Location = new System.Drawing.Point(37, 119);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(106, 24);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.Black;
            this.labelContraseña.Location = new System.Drawing.Point(11, 206);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(142, 24);
            this.labelContraseña.TabIndex = 2;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(15, 139);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(362, 25);
            this.textBoxUsuario.TabIndex = 3;
            this.textBoxUsuario.Tag = "usuario";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(15, 226);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(362, 25);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.Tag = "contraseña";
            this.textBoxContraseña.UseSystemPasswordChar = true;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Black;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(14, 317);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(362, 41);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "ACEPTAR";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Black;
            this.buttonSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalir.Location = new System.Drawing.Point(15, 364);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(362, 41);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Black;
            this.labelError.Location = new System.Drawing.Point(28, 284);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(310, 24);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "Los datos son incorrectos";
            this.labelError.Visible = false;
            this.labelError.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Black;
            this.panelPrincipal.Controls.Add(this.buttonIniciar);
            this.panelPrincipal.Controls.Add(this.buttonAyuda);
            this.panelPrincipal.Controls.Add(this.labelMensajeAccedere);
            this.panelPrincipal.Controls.Add(this.labelIniciarSecion);
            this.panelPrincipal.Controls.Add(this.labelMensajeProblema);
            this.panelPrincipal.Controls.Add(this.labelProblemas);
            this.panelPrincipal.Location = new System.Drawing.Point(4, 55);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(808, 369);
            this.panelPrincipal.TabIndex = 9;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.Transparent;
            this.buttonIniciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciar.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.ForeColor = System.Drawing.Color.White;
            this.buttonIniciar.Location = new System.Drawing.Point(34, 231);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(331, 41);
            this.buttonIniciar.TabIndex = 9;
            this.buttonIniciar.Text = "Acceder";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.BackColor = System.Drawing.Color.Transparent;
            this.buttonAyuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyuda.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAyuda.ForeColor = System.Drawing.Color.White;
            this.buttonAyuda.Location = new System.Drawing.Point(433, 231);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(331, 41);
            this.buttonAyuda.TabIndex = 8;
            this.buttonAyuda.Text = "Soporte";
            this.buttonAyuda.UseVisualStyleBackColor = false;
            this.buttonAyuda.Click += new System.EventHandler(this.buttonAyuda_Click);
            this.buttonAyuda.MouseEnter += new System.EventHandler(this.label1_Click);
            this.buttonAyuda.MouseLeave += new System.EventHandler(this.label1_Leave);
            // 
            // labelMensajeAccedere
            // 
            this.labelMensajeAccedere.AutoSize = true;
            this.labelMensajeAccedere.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensajeAccedere.ForeColor = System.Drawing.Color.White;
            this.labelMensajeAccedere.Location = new System.Drawing.Point(96, 141);
            this.labelMensajeAccedere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMensajeAccedere.Name = "labelMensajeAccedere";
            this.labelMensajeAccedere.Size = new System.Drawing.Size(197, 50);
            this.labelMensajeAccedere.TabIndex = 7;
            this.labelMensajeAccedere.Text = "Da click en acceder \r\npara iniciar sesion.";
            // 
            // labelIniciarSecion
            // 
            this.labelIniciarSecion.AutoSize = true;
            this.labelIniciarSecion.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciarSecion.ForeColor = System.Drawing.Color.White;
            this.labelIniciarSecion.Location = new System.Drawing.Point(28, 59);
            this.labelIniciarSecion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIniciarSecion.Name = "labelIniciarSecion";
            this.labelIniciarSecion.Size = new System.Drawing.Size(339, 32);
            this.labelIniciarSecion.TabIndex = 6;
            this.labelIniciarSecion.Text = "¿Cuentas con un Usuario?";
            // 
            // labelMensajeProblema
            // 
            this.labelMensajeProblema.AutoSize = true;
            this.labelMensajeProblema.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensajeProblema.ForeColor = System.Drawing.Color.White;
            this.labelMensajeProblema.Location = new System.Drawing.Point(507, 141);
            this.labelMensajeProblema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMensajeProblema.Name = "labelMensajeProblema";
            this.labelMensajeProblema.Size = new System.Drawing.Size(197, 50);
            this.labelMensajeProblema.TabIndex = 5;
            this.labelMensajeProblema.Text = "Da click en Soporte \r\npara recibir ayuda.";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.panelIniSes);
            this.panelContenedor.Controls.Add(this.panelSop);
            this.panelContenedor.Location = new System.Drawing.Point(0, 10);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(400, 430);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelIniSes
            // 
            this.panelIniSes.BackColor = System.Drawing.Color.White;
            this.panelIniSes.Controls.Add(this.label6);
            this.panelIniSes.Controls.Add(this.labelError);
            this.panelIniSes.Controls.Add(this.panelContra);
            this.panelIniSes.Controls.Add(this.pUsuario);
            this.panelIniSes.Controls.Add(this.labelUsuario);
            this.panelIniSes.Controls.Add(this.buttonSalir);
            this.panelIniSes.Controls.Add(this.textBoxUsuario);
            this.panelIniSes.Controls.Add(this.buttonAceptar);
            this.panelIniSes.Controls.Add(this.labelContraseña);
            this.panelIniSes.Controls.Add(this.textBoxContraseña);
            this.panelIniSes.Controls.Add(this.pictureBox2);
            this.panelIniSes.Location = new System.Drawing.Point(0, 2);
            this.panelIniSes.Name = "panelIniSes";
            this.panelIniSes.Size = new System.Drawing.Size(397, 420);
            this.panelIniSes.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(110, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "INICIAR SESION";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panelContra
            // 
            this.panelContra.BackColor = System.Drawing.Color.Silver;
            this.panelContra.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContra.Location = new System.Drawing.Point(15, 251);
            this.panelContra.Name = "panelContra";
            this.panelContra.Size = new System.Drawing.Size(362, 3);
            this.panelContra.TabIndex = 12;
            // 
            // pUsuario
            // 
            this.pUsuario.BackColor = System.Drawing.Color.Silver;
            this.pUsuario.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pUsuario.Location = new System.Drawing.Point(15, 164);
            this.pUsuario.Name = "pUsuario";
            this.pUsuario.Size = new System.Drawing.Size(362, 3);
            this.pUsuario.TabIndex = 11;
            // 
            // panelSop
            // 
            this.panelSop.BackColor = System.Drawing.Color.White;
            this.panelSop.Controls.Add(this.panelContraseñaSop);
            this.panelSop.Controls.Add(this.labelContraSop);
            this.panelSop.Controls.Add(this.textBoxConstraSop);
            this.panelSop.Controls.Add(this.panelUsuarioSop);
            this.panelSop.Controls.Add(this.labelUsuarioSop);
            this.panelSop.Controls.Add(this.textBoxUsuarioSop);
            this.panelSop.Controls.Add(this.label7);
            this.panelSop.Controls.Add(this.panelCorreoSop);
            this.panelSop.Controls.Add(this.labelCorreoSop);
            this.panelSop.Controls.Add(this.textBoxCorreoSop);
            this.panelSop.Controls.Add(this.panelNombreSop);
            this.panelSop.Controls.Add(this.labelNombreSop);
            this.panelSop.Controls.Add(this.button1);
            this.panelSop.Controls.Add(this.textBoxNombreSop);
            this.panelSop.Controls.Add(this.button2);
            this.panelSop.Controls.Add(this.pictureBox1);
            this.panelSop.Location = new System.Drawing.Point(0, 2);
            this.panelSop.Name = "panelSop";
            this.panelSop.Size = new System.Drawing.Size(390, 420);
            this.panelSop.TabIndex = 2;
            // 
            // panelContraseñaSop
            // 
            this.panelContraseñaSop.BackColor = System.Drawing.Color.Silver;
            this.panelContraseñaSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContraseñaSop.Location = new System.Drawing.Point(14, 310);
            this.panelContraseñaSop.Name = "panelContraseñaSop";
            this.panelContraseñaSop.Size = new System.Drawing.Size(362, 3);
            this.panelContraseñaSop.TabIndex = 25;
            // 
            // labelContraSop
            // 
            this.labelContraSop.AutoSize = true;
            this.labelContraSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraSop.ForeColor = System.Drawing.Color.Black;
            this.labelContraSop.Location = new System.Drawing.Point(36, 263);
            this.labelContraSop.Name = "labelContraSop";
            this.labelContraSop.Size = new System.Drawing.Size(142, 24);
            this.labelContraSop.TabIndex = 23;
            this.labelContraSop.Text = "Contraseña:";
            // 
            // textBoxConstraSop
            // 
            this.textBoxConstraSop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConstraSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConstraSop.Location = new System.Drawing.Point(14, 284);
            this.textBoxConstraSop.Name = "textBoxConstraSop";
            this.textBoxConstraSop.Size = new System.Drawing.Size(362, 25);
            this.textBoxConstraSop.TabIndex = 24;
            this.textBoxConstraSop.Tag = "ContraseñaSop";
            this.textBoxConstraSop.Enter += new System.EventHandler(this.txtEnter);
            this.textBoxConstraSop.Leave += new System.EventHandler(this.txtLeave);
            // 
            // panelUsuarioSop
            // 
            this.panelUsuarioSop.BackColor = System.Drawing.Color.Silver;
            this.panelUsuarioSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUsuarioSop.Location = new System.Drawing.Point(14, 242);
            this.panelUsuarioSop.Name = "panelUsuarioSop";
            this.panelUsuarioSop.Size = new System.Drawing.Size(362, 3);
            this.panelUsuarioSop.TabIndex = 22;
            // 
            // labelUsuarioSop
            // 
            this.labelUsuarioSop.AutoSize = true;
            this.labelUsuarioSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioSop.ForeColor = System.Drawing.Color.Black;
            this.labelUsuarioSop.Location = new System.Drawing.Point(36, 197);
            this.labelUsuarioSop.Name = "labelUsuarioSop";
            this.labelUsuarioSop.Size = new System.Drawing.Size(106, 24);
            this.labelUsuarioSop.TabIndex = 20;
            this.labelUsuarioSop.Text = "Usuario:";
            // 
            // textBoxUsuarioSop
            // 
            this.textBoxUsuarioSop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuarioSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioSop.Location = new System.Drawing.Point(12, 220);
            this.textBoxUsuarioSop.Name = "textBoxUsuarioSop";
            this.textBoxUsuarioSop.Size = new System.Drawing.Size(362, 25);
            this.textBoxUsuarioSop.TabIndex = 21;
            this.textBoxUsuarioSop.Tag = "UsuarioSop";
            this.textBoxUsuarioSop.Enter += new System.EventHandler(this.txtEnter);
            this.textBoxUsuarioSop.Leave += new System.EventHandler(this.txtLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(144, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "SOPORTE";
            // 
            // panelCorreoSop
            // 
            this.panelCorreoSop.BackColor = System.Drawing.Color.Silver;
            this.panelCorreoSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCorreoSop.Location = new System.Drawing.Point(12, 180);
            this.panelCorreoSop.Name = "panelCorreoSop";
            this.panelCorreoSop.Size = new System.Drawing.Size(362, 3);
            this.panelCorreoSop.TabIndex = 17;
            // 
            // labelCorreoSop
            // 
            this.labelCorreoSop.AutoSize = true;
            this.labelCorreoSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoSop.ForeColor = System.Drawing.Color.Black;
            this.labelCorreoSop.Location = new System.Drawing.Point(34, 133);
            this.labelCorreoSop.Name = "labelCorreoSop";
            this.labelCorreoSop.Size = new System.Drawing.Size(238, 24);
            this.labelCorreoSop.TabIndex = 13;
            this.labelCorreoSop.Text = "Correo electronico:";
            // 
            // textBoxCorreoSop
            // 
            this.textBoxCorreoSop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreoSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoSop.Location = new System.Drawing.Point(12, 155);
            this.textBoxCorreoSop.Name = "textBoxCorreoSop";
            this.textBoxCorreoSop.Size = new System.Drawing.Size(362, 25);
            this.textBoxCorreoSop.TabIndex = 15;
            this.textBoxCorreoSop.Tag = "CorreoSop";
            this.textBoxCorreoSop.Enter += new System.EventHandler(this.txtEnter);
            this.textBoxCorreoSop.Leave += new System.EventHandler(this.txtLeave);
            // 
            // panelNombreSop
            // 
            this.panelNombreSop.BackColor = System.Drawing.Color.Silver;
            this.panelNombreSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNombreSop.Location = new System.Drawing.Point(12, 112);
            this.panelNombreSop.Name = "panelNombreSop";
            this.panelNombreSop.Size = new System.Drawing.Size(362, 3);
            this.panelNombreSop.TabIndex = 11;
            // 
            // labelNombreSop
            // 
            this.labelNombreSop.AutoSize = true;
            this.labelNombreSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreSop.ForeColor = System.Drawing.Color.Black;
            this.labelNombreSop.Location = new System.Drawing.Point(34, 67);
            this.labelNombreSop.Name = "labelNombreSop";
            this.labelNombreSop.Size = new System.Drawing.Size(106, 24);
            this.labelNombreSop.TabIndex = 1;
            this.labelNombreSop.Text = "Nombre :";
            this.labelNombreSop.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(15, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombreSop
            // 
            this.textBoxNombreSop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreSop.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreSop.Location = new System.Drawing.Point(12, 90);
            this.textBoxNombreSop.Name = "textBoxNombreSop";
            this.textBoxNombreSop.Size = new System.Drawing.Size(362, 25);
            this.textBoxNombreSop.TabIndex = 3;
            this.textBoxNombreSop.Tag = "NombreSop";
            this.textBoxNombreSop.Enter += new System.EventHandler(this.txtEnter);
            this.textBoxNombreSop.Leave += new System.EventHandler(this.txtLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(14, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(362, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "ENVIAR DATOS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(259, -12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VentanaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificacion";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.VentanaInicio_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelIniSes.ResumeLayout(false);
            this.panelIniSes.PerformLayout();
            this.panelSop.ResumeLayout(false);
            this.panelSop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelProblemas;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.Label labelMensajeAccedere;
        private System.Windows.Forms.Label labelIniciarSecion;
        private System.Windows.Forms.Label labelMensajeProblema;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelIniSes;
        private System.Windows.Forms.Panel pUsuario;
        private System.Windows.Forms.Panel panelContra;
        private System.Windows.Forms.Panel panelSop;
        private System.Windows.Forms.Panel panelCorreoSop;
        private System.Windows.Forms.Label labelCorreoSop;
        private System.Windows.Forms.TextBox textBoxCorreoSop;
        private System.Windows.Forms.Panel panelNombreSop;
        private System.Windows.Forms.Label labelNombreSop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNombreSop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelContraseñaSop;
        private System.Windows.Forms.Label labelContraSop;
        private System.Windows.Forms.TextBox textBoxConstraSop;
        private System.Windows.Forms.Panel panelUsuarioSop;
        private System.Windows.Forms.Label labelUsuarioSop;
        private System.Windows.Forms.TextBox textBoxUsuarioSop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

