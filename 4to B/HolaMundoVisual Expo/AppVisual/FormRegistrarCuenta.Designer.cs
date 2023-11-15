namespace AppVisual
{
    partial class FormRegistrarCuenta
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
            this.labelVisualCuentas = new System.Windows.Forms.Label();
            this.dataGridViewCuentas = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxContraseñaCuenta = new System.Windows.Forms.TextBox();
            this.labelContraseñaCuenta = new System.Windows.Forms.Label();
            this.labelCorreoCuenta = new System.Windows.Forms.Label();
            this.textBoxCorreoCuenta = new System.Windows.Forms.TextBox();
            this.labelIdCuenta = new System.Windows.Forms.Label();
            this.textBoxIdCuenta = new System.Windows.Forms.TextBox();
            this.ButttonRegistrar = new System.Windows.Forms.Button();
            this.labelRegistroCuentas = new System.Windows.Forms.Label();
            this.labelFechaCargaCuenta = new System.Windows.Forms.Label();
            this.labelFechaCreacionCuenta = new System.Windows.Forms.Label();
            this.dateTimePickerFechaCreacioCuenta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaCargaCuenta = new System.Windows.Forms.DateTimePicker();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVisualCuentas
            // 
            this.labelVisualCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVisualCuentas.AutoSize = true;
            this.labelVisualCuentas.BackColor = System.Drawing.Color.White;
            this.labelVisualCuentas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisualCuentas.ForeColor = System.Drawing.Color.Black;
            this.labelVisualCuentas.Location = new System.Drawing.Point(279, 264);
            this.labelVisualCuentas.Name = "labelVisualCuentas";
            this.labelVisualCuentas.Size = new System.Drawing.Size(121, 19);
            this.labelVisualCuentas.TabIndex = 58;
            this.labelVisualCuentas.Text = "Lista de Cuentas";
            // 
            // dataGridViewCuentas
            // 
            this.dataGridViewCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCuentas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCuentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuentas.Location = new System.Drawing.Point(89, 286);
            this.dataGridViewCuentas.Name = "dataGridViewCuentas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCuentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCuentas.Size = new System.Drawing.Size(508, 150);
            this.dataGridViewCuentas.TabIndex = 57;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.BackColor = System.Drawing.Color.Gray;
            this.buttonLimpiar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(89, 213);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(130, 45);
            this.buttonLimpiar.TabIndex = 56;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxContraseñaCuenta
            // 
            this.textBoxContraseñaCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContraseñaCuenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseñaCuenta.Location = new System.Drawing.Point(209, 177);
            this.textBoxContraseñaCuenta.Name = "textBoxContraseñaCuenta";
            this.textBoxContraseñaCuenta.Size = new System.Drawing.Size(100, 27);
            this.textBoxContraseñaCuenta.TabIndex = 55;
            // 
            // labelContraseñaCuenta
            // 
            this.labelContraseñaCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContraseñaCuenta.AutoSize = true;
            this.labelContraseñaCuenta.BackColor = System.Drawing.Color.White;
            this.labelContraseñaCuenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseñaCuenta.ForeColor = System.Drawing.Color.Black;
            this.labelContraseñaCuenta.Location = new System.Drawing.Point(55, 180);
            this.labelContraseñaCuenta.Name = "labelContraseñaCuenta";
            this.labelContraseñaCuenta.Size = new System.Drawing.Size(139, 19);
            this.labelContraseñaCuenta.TabIndex = 54;
            this.labelContraseñaCuenta.Text = "Contraseña Cuenta";
            // 
            // labelCorreoCuenta
            // 
            this.labelCorreoCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCorreoCuenta.AutoSize = true;
            this.labelCorreoCuenta.BackColor = System.Drawing.Color.White;
            this.labelCorreoCuenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCorreoCuenta.Location = new System.Drawing.Point(55, 135);
            this.labelCorreoCuenta.Name = "labelCorreoCuenta";
            this.labelCorreoCuenta.Size = new System.Drawing.Size(107, 19);
            this.labelCorreoCuenta.TabIndex = 53;
            this.labelCorreoCuenta.Text = "Correo Cuenta";
            // 
            // textBoxCorreoCuenta
            // 
            this.textBoxCorreoCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCorreoCuenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoCuenta.Location = new System.Drawing.Point(209, 132);
            this.textBoxCorreoCuenta.Name = "textBoxCorreoCuenta";
            this.textBoxCorreoCuenta.Size = new System.Drawing.Size(100, 27);
            this.textBoxCorreoCuenta.TabIndex = 52;
            // 
            // labelIdCuenta
            // 
            this.labelIdCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdCuenta.AutoSize = true;
            this.labelIdCuenta.BackColor = System.Drawing.Color.White;
            this.labelIdCuenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdCuenta.Location = new System.Drawing.Point(55, 86);
            this.labelIdCuenta.Name = "labelIdCuenta";
            this.labelIdCuenta.Size = new System.Drawing.Size(73, 19);
            this.labelIdCuenta.TabIndex = 51;
            this.labelIdCuenta.Text = "id Cuenta";
            // 
            // textBoxIdCuenta
            // 
            this.textBoxIdCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdCuenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdCuenta.Location = new System.Drawing.Point(209, 83);
            this.textBoxIdCuenta.Name = "textBoxIdCuenta";
            this.textBoxIdCuenta.Size = new System.Drawing.Size(100, 27);
            this.textBoxIdCuenta.TabIndex = 50;
            // 
            // ButttonRegistrar
            // 
            this.ButttonRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButttonRegistrar.BackColor = System.Drawing.Color.Gray;
            this.ButttonRegistrar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButttonRegistrar.Location = new System.Drawing.Point(283, 213);
            this.ButttonRegistrar.Name = "ButttonRegistrar";
            this.ButttonRegistrar.Size = new System.Drawing.Size(130, 45);
            this.ButttonRegistrar.TabIndex = 49;
            this.ButttonRegistrar.Text = "Registrar";
            this.ButttonRegistrar.UseVisualStyleBackColor = false;
            this.ButttonRegistrar.Click += new System.EventHandler(this.ButttonRegistrar_Click);
            // 
            // labelRegistroCuentas
            // 
            this.labelRegistroCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegistroCuentas.AutoSize = true;
            this.labelRegistroCuentas.BackColor = System.Drawing.Color.White;
            this.labelRegistroCuentas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroCuentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegistroCuentas.Location = new System.Drawing.Point(265, 33);
            this.labelRegistroCuentas.Name = "labelRegistroCuentas";
            this.labelRegistroCuentas.Size = new System.Drawing.Size(154, 19);
            this.labelRegistroCuentas.TabIndex = 48;
            this.labelRegistroCuentas.Text = "REGISTRO CUENTAS";
            // 
            // labelFechaCargaCuenta
            // 
            this.labelFechaCargaCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFechaCargaCuenta.AutoSize = true;
            this.labelFechaCargaCuenta.BackColor = System.Drawing.Color.White;
            this.labelFechaCargaCuenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCargaCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFechaCargaCuenta.Location = new System.Drawing.Point(346, 135);
            this.labelFechaCargaCuenta.Name = "labelFechaCargaCuenta";
            this.labelFechaCargaCuenta.Size = new System.Drawing.Size(91, 19);
            this.labelFechaCargaCuenta.TabIndex = 60;
            this.labelFechaCargaCuenta.Text = "Fecha Carga";
            // 
            // labelFechaCreacionCuenta
            // 
            this.labelFechaCreacionCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFechaCreacionCuenta.AutoSize = true;
            this.labelFechaCreacionCuenta.BackColor = System.Drawing.Color.White;
            this.labelFechaCreacionCuenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCreacionCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFechaCreacionCuenta.Location = new System.Drawing.Point(346, 86);
            this.labelFechaCreacionCuenta.Name = "labelFechaCreacionCuenta";
            this.labelFechaCreacionCuenta.Size = new System.Drawing.Size(111, 19);
            this.labelFechaCreacionCuenta.TabIndex = 59;
            this.labelFechaCreacionCuenta.Text = "Fecha Creacion";
            // 
            // dateTimePickerFechaCreacioCuenta
            // 
            this.dateTimePickerFechaCreacioCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFechaCreacioCuenta.Location = new System.Drawing.Point(472, 86);
            this.dateTimePickerFechaCreacioCuenta.Name = "dateTimePickerFechaCreacioCuenta";
            this.dateTimePickerFechaCreacioCuenta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaCreacioCuenta.TabIndex = 61;
            // 
            // dateTimePickerFechaCargaCuenta
            // 
            this.dateTimePickerFechaCargaCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFechaCargaCuenta.Location = new System.Drawing.Point(472, 135);
            this.dateTimePickerFechaCargaCuenta.Name = "dateTimePickerFechaCargaCuenta";
            this.dateTimePickerFechaCargaCuenta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaCargaCuenta.TabIndex = 62;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.Color.Gray;
            this.buttonEliminar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(467, 213);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(130, 45);
            this.buttonEliminar.TabIndex = 64;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // FormRegistrarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dateTimePickerFechaCargaCuenta);
            this.Controls.Add(this.dateTimePickerFechaCreacioCuenta);
            this.Controls.Add(this.labelFechaCargaCuenta);
            this.Controls.Add(this.labelFechaCreacionCuenta);
            this.Controls.Add(this.labelVisualCuentas);
            this.Controls.Add(this.dataGridViewCuentas);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxContraseñaCuenta);
            this.Controls.Add(this.labelContraseñaCuenta);
            this.Controls.Add(this.labelCorreoCuenta);
            this.Controls.Add(this.textBoxCorreoCuenta);
            this.Controls.Add(this.labelIdCuenta);
            this.Controls.Add(this.textBoxIdCuenta);
            this.Controls.Add(this.ButttonRegistrar);
            this.Controls.Add(this.labelRegistroCuentas);
            this.Name = "FormRegistrarCuenta";
            this.Text = "FormRegistrarCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVisualCuentas;
        private System.Windows.Forms.DataGridView dataGridViewCuentas;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxContraseñaCuenta;
        private System.Windows.Forms.Label labelContraseñaCuenta;
        private System.Windows.Forms.Label labelCorreoCuenta;
        private System.Windows.Forms.TextBox textBoxCorreoCuenta;
        private System.Windows.Forms.Label labelIdCuenta;
        private System.Windows.Forms.TextBox textBoxIdCuenta;
        private System.Windows.Forms.Button ButttonRegistrar;
        private System.Windows.Forms.Label labelRegistroCuentas;
        private System.Windows.Forms.Label labelFechaCargaCuenta;
        private System.Windows.Forms.Label labelFechaCreacionCuenta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCreacioCuenta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCargaCuenta;
        private System.Windows.Forms.Button buttonEliminar;
    }
}