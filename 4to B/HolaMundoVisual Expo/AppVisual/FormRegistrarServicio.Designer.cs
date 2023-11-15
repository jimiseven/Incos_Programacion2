namespace AppVisual
{
    partial class FormRegistrarServicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelVisualServicio = new System.Windows.Forms.Label();
            this.dataGridViewServicios = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxCorreoPadre = new System.Windows.Forms.TextBox();
            this.labelCorreoPadre = new System.Windows.Forms.Label();
            this.labelNombreServicio = new System.Windows.Forms.Label();
            this.labelIdServicio = new System.Windows.Forms.Label();
            this.textBoxIdServicio = new System.Windows.Forms.TextBox();
            this.ButttonRegistrar = new System.Windows.Forms.Button();
            this.labelRegistroServicio = new System.Windows.Forms.Label();
            this.labelFechaCreacionServicio = new System.Windows.Forms.Label();
            this.labelContraseñaPadre = new System.Windows.Forms.Label();
            this.textBoxContraseñaPadre = new System.Windows.Forms.TextBox();
            this.comboBoxServicios = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.button1Modificar = new System.Windows.Forms.Button();
            this.button1GMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVisualServicio
            // 
            this.labelVisualServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVisualServicio.AutoSize = true;
            this.labelVisualServicio.BackColor = System.Drawing.Color.White;
            this.labelVisualServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisualServicio.ForeColor = System.Drawing.Color.Black;
            this.labelVisualServicio.Location = new System.Drawing.Point(299, 306);
            this.labelVisualServicio.Name = "labelVisualServicio";
            this.labelVisualServicio.Size = new System.Drawing.Size(128, 19);
            this.labelVisualServicio.TabIndex = 47;
            this.labelVisualServicio.Text = "Lista de Servicios";
            this.labelVisualServicio.Click += new System.EventHandler(this.labelVisualServicio_Click);
            // 
            // dataGridViewServicios
            // 
            this.dataGridViewServicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewServicios.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewServicios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicios.Location = new System.Drawing.Point(95, 328);
            this.dataGridViewServicios.Name = "dataGridViewServicios";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewServicios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewServicios.Size = new System.Drawing.Size(508, 108);
            this.dataGridViewServicios.TabIndex = 46;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLimpiar.BackColor = System.Drawing.Color.Gray;
            this.buttonLimpiar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(164, 229);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(112, 33);
            this.buttonLimpiar.TabIndex = 45;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxCorreoPadre
            // 
            this.textBoxCorreoPadre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCorreoPadre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoPadre.Location = new System.Drawing.Point(206, 175);
            this.textBoxCorreoPadre.Name = "textBoxCorreoPadre";
            this.textBoxCorreoPadre.Size = new System.Drawing.Size(100, 27);
            this.textBoxCorreoPadre.TabIndex = 44;
            // 
            // labelCorreoPadre
            // 
            this.labelCorreoPadre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCorreoPadre.AutoSize = true;
            this.labelCorreoPadre.BackColor = System.Drawing.Color.White;
            this.labelCorreoPadre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoPadre.ForeColor = System.Drawing.Color.Black;
            this.labelCorreoPadre.Location = new System.Drawing.Point(56, 183);
            this.labelCorreoPadre.Name = "labelCorreoPadre";
            this.labelCorreoPadre.Size = new System.Drawing.Size(100, 19);
            this.labelCorreoPadre.TabIndex = 43;
            this.labelCorreoPadre.Text = "Correo Padre";
            // 
            // labelNombreServicio
            // 
            this.labelNombreServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombreServicio.AutoSize = true;
            this.labelNombreServicio.BackColor = System.Drawing.Color.White;
            this.labelNombreServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNombreServicio.Location = new System.Drawing.Point(56, 135);
            this.labelNombreServicio.Name = "labelNombreServicio";
            this.labelNombreServicio.Size = new System.Drawing.Size(125, 19);
            this.labelNombreServicio.TabIndex = 42;
            this.labelNombreServicio.Text = "Nombre Servicio";
            // 
            // labelIdServicio
            // 
            this.labelIdServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIdServicio.AutoSize = true;
            this.labelIdServicio.BackColor = System.Drawing.Color.White;
            this.labelIdServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdServicio.Location = new System.Drawing.Point(56, 86);
            this.labelIdServicio.Name = "labelIdServicio";
            this.labelIdServicio.Size = new System.Drawing.Size(80, 19);
            this.labelIdServicio.TabIndex = 40;
            this.labelIdServicio.Text = "id Servicio";
            // 
            // textBoxIdServicio
            // 
            this.textBoxIdServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIdServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdServicio.Location = new System.Drawing.Point(206, 83);
            this.textBoxIdServicio.Name = "textBoxIdServicio";
            this.textBoxIdServicio.Size = new System.Drawing.Size(100, 27);
            this.textBoxIdServicio.TabIndex = 39;
            // 
            // ButttonRegistrar
            // 
            this.ButttonRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButttonRegistrar.BackColor = System.Drawing.Color.Gray;
            this.ButttonRegistrar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButttonRegistrar.Location = new System.Drawing.Point(26, 229);
            this.ButttonRegistrar.Name = "ButttonRegistrar";
            this.ButttonRegistrar.Size = new System.Drawing.Size(112, 33);
            this.ButttonRegistrar.TabIndex = 38;
            this.ButttonRegistrar.Text = "Registrar";
            this.ButttonRegistrar.UseVisualStyleBackColor = false;
            this.ButttonRegistrar.Click += new System.EventHandler(this.ButttonRegistrar_Click);
            // 
            // labelRegistroServicio
            // 
            this.labelRegistroServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegistroServicio.AutoSize = true;
            this.labelRegistroServicio.BackColor = System.Drawing.Color.White;
            this.labelRegistroServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegistroServicio.Location = new System.Drawing.Point(265, 33);
            this.labelRegistroServicio.Name = "labelRegistroServicio";
            this.labelRegistroServicio.Size = new System.Drawing.Size(162, 19);
            this.labelRegistroServicio.TabIndex = 37;
            this.labelRegistroServicio.Text = "REGISTRO SERVICIOS";
            // 
            // labelFechaCreacionServicio
            // 
            this.labelFechaCreacionServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFechaCreacionServicio.AutoSize = true;
            this.labelFechaCreacionServicio.BackColor = System.Drawing.Color.White;
            this.labelFechaCreacionServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCreacionServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFechaCreacionServicio.Location = new System.Drawing.Point(343, 135);
            this.labelFechaCreacionServicio.Name = "labelFechaCreacionServicio";
            this.labelFechaCreacionServicio.Size = new System.Drawing.Size(169, 19);
            this.labelFechaCreacionServicio.TabIndex = 51;
            this.labelFechaCreacionServicio.Text = "Fecha Creacion Servicio";
            // 
            // labelContraseñaPadre
            // 
            this.labelContraseñaPadre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContraseñaPadre.AutoSize = true;
            this.labelContraseñaPadre.BackColor = System.Drawing.Color.White;
            this.labelContraseñaPadre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseñaPadre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelContraseñaPadre.Location = new System.Drawing.Point(343, 86);
            this.labelContraseñaPadre.Name = "labelContraseñaPadre";
            this.labelContraseñaPadre.Size = new System.Drawing.Size(132, 19);
            this.labelContraseñaPadre.TabIndex = 49;
            this.labelContraseñaPadre.Text = "Contraseña Padre";
            // 
            // textBoxContraseñaPadre
            // 
            this.textBoxContraseñaPadre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContraseñaPadre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseñaPadre.Location = new System.Drawing.Point(525, 83);
            this.textBoxContraseñaPadre.Name = "textBoxContraseñaPadre";
            this.textBoxContraseñaPadre.Size = new System.Drawing.Size(100, 27);
            this.textBoxContraseñaPadre.TabIndex = 48;
            // 
            // comboBoxServicios
            // 
            this.comboBoxServicios.BackColor = System.Drawing.Color.White;
            this.comboBoxServicios.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServicios.ForeColor = System.Drawing.Color.Black;
            this.comboBoxServicios.FormattingEnabled = true;
            this.comboBoxServicios.Items.AddRange(new object[] {
            "Netflix",
            "Star + ",
            "Disney +"});
            this.comboBoxServicios.Location = new System.Drawing.Point(206, 132);
            this.comboBoxServicios.Name = "comboBoxServicios";
            this.comboBoxServicios.Size = new System.Drawing.Size(100, 27);
            this.comboBoxServicios.TabIndex = 52;
            // 
            // dateTimePickerFechaCreacion
            // 
            this.dateTimePickerFechaCreacion.Location = new System.Drawing.Point(525, 133);
            this.dateTimePickerFechaCreacion.Name = "dateTimePickerFechaCreacion";
            this.dateTimePickerFechaCreacion.Size = new System.Drawing.Size(154, 20);
            this.dateTimePickerFechaCreacion.TabIndex = 53;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEliminar.BackColor = System.Drawing.Color.Gray;
            this.buttonEliminar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(560, 229);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(112, 33);
            this.buttonEliminar.TabIndex = 55;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // button1Modificar
            // 
            this.button1Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1Modificar.BackColor = System.Drawing.Color.Gray;
            this.button1Modificar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Modificar.Location = new System.Drawing.Point(303, 229);
            this.button1Modificar.Name = "button1Modificar";
            this.button1Modificar.Size = new System.Drawing.Size(112, 33);
            this.button1Modificar.TabIndex = 56;
            this.button1Modificar.Text = "Modificar";
            this.button1Modificar.UseVisualStyleBackColor = false;
            this.button1Modificar.Click += new System.EventHandler(this.button1Modificar_Click);
            // 
            // button1GMod
            // 
            this.button1GMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1GMod.BackColor = System.Drawing.Color.Gray;
            this.button1GMod.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1GMod.Location = new System.Drawing.Point(442, 229);
            this.button1GMod.Name = "button1GMod";
            this.button1GMod.Size = new System.Drawing.Size(112, 33);
            this.button1GMod.TabIndex = 57;
            this.button1GMod.Text = "GuardarMod";
            this.button1GMod.UseVisualStyleBackColor = false;
            this.button1GMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegistrarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.button1GMod);
            this.Controls.Add(this.button1Modificar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dateTimePickerFechaCreacion);
            this.Controls.Add(this.comboBoxServicios);
            this.Controls.Add(this.labelFechaCreacionServicio);
            this.Controls.Add(this.labelContraseñaPadre);
            this.Controls.Add(this.textBoxContraseñaPadre);
            this.Controls.Add(this.labelVisualServicio);
            this.Controls.Add(this.dataGridViewServicios);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxCorreoPadre);
            this.Controls.Add(this.labelCorreoPadre);
            this.Controls.Add(this.labelNombreServicio);
            this.Controls.Add(this.labelIdServicio);
            this.Controls.Add(this.textBoxIdServicio);
            this.Controls.Add(this.ButttonRegistrar);
            this.Controls.Add(this.labelRegistroServicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRegistrarServicio";
            this.Text = "FormRegistrarServicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVisualServicio;
        private System.Windows.Forms.DataGridView dataGridViewServicios;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxCorreoPadre;
        private System.Windows.Forms.Label labelCorreoPadre;
        private System.Windows.Forms.Label labelNombreServicio;
        private System.Windows.Forms.Label labelIdServicio;
        private System.Windows.Forms.TextBox textBoxIdServicio;
        private System.Windows.Forms.Button ButttonRegistrar;
        private System.Windows.Forms.Label labelRegistroServicio;
        private System.Windows.Forms.Label labelFechaCreacionServicio;
        private System.Windows.Forms.Label labelContraseñaPadre;
        private System.Windows.Forms.TextBox textBoxContraseñaPadre;
        private System.Windows.Forms.ComboBox comboBoxServicios;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCreacion;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button button1Modificar;
        private System.Windows.Forms.Button button1GMod;
    }
}