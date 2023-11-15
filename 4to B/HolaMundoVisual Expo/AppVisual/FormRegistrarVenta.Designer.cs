namespace AppVisual
{
    partial class FormRegistrarVenta
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
            this.dateTimePickerFechaFinVenta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicioVenta = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFinVenta = new System.Windows.Forms.Label();
            this.labelFechaInicioVenta = new System.Windows.Forms.Label();
            this.labelVisualVentas = new System.Windows.Forms.Label();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxNombreVenta = new System.Windows.Forms.TextBox();
            this.labelNombreVenta = new System.Windows.Forms.Label();
            this.labelNumeroCelularVenta = new System.Windows.Forms.Label();
            this.textBoxNumeroCelularVenta = new System.Windows.Forms.TextBox();
            this.labelIdVenta = new System.Windows.Forms.Label();
            this.textBoxIdVenta = new System.Windows.Forms.TextBox();
            this.ButttonRegistrar = new System.Windows.Forms.Button();
            this.labelRegistroVenta = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.button1Guar = new System.Windows.Forms.Button();
            this.button2Mod = new System.Windows.Forms.Button();
            this.button1Rep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFechaFinVenta
            // 
            this.dateTimePickerFechaFinVenta.Location = new System.Drawing.Point(451, 125);
            this.dateTimePickerFechaFinVenta.Name = "dateTimePickerFechaFinVenta";
            this.dateTimePickerFechaFinVenta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaFinVenta.TabIndex = 92;
            // 
            // dateTimePickerFechaInicioVenta
            // 
            this.dateTimePickerFechaInicioVenta.Location = new System.Drawing.Point(451, 76);
            this.dateTimePickerFechaInicioVenta.Name = "dateTimePickerFechaInicioVenta";
            this.dateTimePickerFechaInicioVenta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaInicioVenta.TabIndex = 91;
            // 
            // labelFechaFinVenta
            // 
            this.labelFechaFinVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFechaFinVenta.AutoSize = true;
            this.labelFechaFinVenta.BackColor = System.Drawing.Color.White;
            this.labelFechaFinVenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFinVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFechaFinVenta.Location = new System.Drawing.Point(325, 125);
            this.labelFechaFinVenta.Name = "labelFechaFinVenta";
            this.labelFechaFinVenta.Size = new System.Drawing.Size(73, 19);
            this.labelFechaFinVenta.TabIndex = 90;
            this.labelFechaFinVenta.Text = "Fecha Fin";
            // 
            // labelFechaInicioVenta
            // 
            this.labelFechaInicioVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFechaInicioVenta.AutoSize = true;
            this.labelFechaInicioVenta.BackColor = System.Drawing.Color.White;
            this.labelFechaInicioVenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicioVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFechaInicioVenta.Location = new System.Drawing.Point(325, 76);
            this.labelFechaInicioVenta.Name = "labelFechaInicioVenta";
            this.labelFechaInicioVenta.Size = new System.Drawing.Size(89, 19);
            this.labelFechaInicioVenta.TabIndex = 89;
            this.labelFechaInicioVenta.Text = "Fecha Inicio";
            // 
            // labelVisualVentas
            // 
            this.labelVisualVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVisualVentas.AutoSize = true;
            this.labelVisualVentas.BackColor = System.Drawing.Color.White;
            this.labelVisualVentas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisualVentas.ForeColor = System.Drawing.Color.Black;
            this.labelVisualVentas.Location = new System.Drawing.Point(258, 254);
            this.labelVisualVentas.Name = "labelVisualVentas";
            this.labelVisualVentas.Size = new System.Drawing.Size(112, 19);
            this.labelVisualVentas.TabIndex = 88;
            this.labelVisualVentas.Text = "Lista de Ventas";
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewVentas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Location = new System.Drawing.Point(68, 276);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVentas.Size = new System.Drawing.Size(508, 150);
            this.dataGridViewVentas.TabIndex = 87;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLimpiar.BackColor = System.Drawing.Color.Gray;
            this.buttonLimpiar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(159, 206);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(115, 45);
            this.buttonLimpiar.TabIndex = 86;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxNombreVenta
            // 
            this.textBoxNombreVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNombreVenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreVenta.Location = new System.Drawing.Point(188, 167);
            this.textBoxNombreVenta.Name = "textBoxNombreVenta";
            this.textBoxNombreVenta.Size = new System.Drawing.Size(100, 27);
            this.textBoxNombreVenta.TabIndex = 85;
            // 
            // labelNombreVenta
            // 
            this.labelNombreVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombreVenta.AutoSize = true;
            this.labelNombreVenta.BackColor = System.Drawing.Color.White;
            this.labelNombreVenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreVenta.ForeColor = System.Drawing.Color.Black;
            this.labelNombreVenta.Location = new System.Drawing.Point(34, 170);
            this.labelNombreVenta.Name = "labelNombreVenta";
            this.labelNombreVenta.Size = new System.Drawing.Size(109, 19);
            this.labelNombreVenta.TabIndex = 84;
            this.labelNombreVenta.Text = "Nombre Venta";
            // 
            // labelNumeroCelularVenta
            // 
            this.labelNumeroCelularVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumeroCelularVenta.AutoSize = true;
            this.labelNumeroCelularVenta.BackColor = System.Drawing.Color.White;
            this.labelNumeroCelularVenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroCelularVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNumeroCelularVenta.Location = new System.Drawing.Point(34, 125);
            this.labelNumeroCelularVenta.Name = "labelNumeroCelularVenta";
            this.labelNumeroCelularVenta.Size = new System.Drawing.Size(117, 19);
            this.labelNumeroCelularVenta.TabIndex = 83;
            this.labelNumeroCelularVenta.Text = "Numero Celular";
            // 
            // textBoxNumeroCelularVenta
            // 
            this.textBoxNumeroCelularVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumeroCelularVenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroCelularVenta.Location = new System.Drawing.Point(188, 122);
            this.textBoxNumeroCelularVenta.Name = "textBoxNumeroCelularVenta";
            this.textBoxNumeroCelularVenta.Size = new System.Drawing.Size(100, 27);
            this.textBoxNumeroCelularVenta.TabIndex = 82;
            // 
            // labelIdVenta
            // 
            this.labelIdVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIdVenta.AutoSize = true;
            this.labelIdVenta.BackColor = System.Drawing.Color.White;
            this.labelIdVenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdVenta.Location = new System.Drawing.Point(34, 76);
            this.labelIdVenta.Name = "labelIdVenta";
            this.labelIdVenta.Size = new System.Drawing.Size(64, 19);
            this.labelIdVenta.TabIndex = 81;
            this.labelIdVenta.Text = "id Venta";
            // 
            // textBoxIdVenta
            // 
            this.textBoxIdVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIdVenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdVenta.Location = new System.Drawing.Point(188, 73);
            this.textBoxIdVenta.Name = "textBoxIdVenta";
            this.textBoxIdVenta.Size = new System.Drawing.Size(100, 27);
            this.textBoxIdVenta.TabIndex = 80;
            // 
            // ButttonRegistrar
            // 
            this.ButttonRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButttonRegistrar.BackColor = System.Drawing.Color.Gray;
            this.ButttonRegistrar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButttonRegistrar.Location = new System.Drawing.Point(38, 206);
            this.ButttonRegistrar.Name = "ButttonRegistrar";
            this.ButttonRegistrar.Size = new System.Drawing.Size(115, 45);
            this.ButttonRegistrar.TabIndex = 79;
            this.ButttonRegistrar.Text = "Registrar";
            this.ButttonRegistrar.UseVisualStyleBackColor = false;
            this.ButttonRegistrar.Click += new System.EventHandler(this.ButttonRegistrar_Click);
            // 
            // labelRegistroVenta
            // 
            this.labelRegistroVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegistroVenta.AutoSize = true;
            this.labelRegistroVenta.BackColor = System.Drawing.Color.White;
            this.labelRegistroVenta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegistroVenta.Location = new System.Drawing.Point(244, 23);
            this.labelRegistroVenta.Name = "labelRegistroVenta";
            this.labelRegistroVenta.Size = new System.Drawing.Size(144, 19);
            this.labelRegistroVenta.TabIndex = 78;
            this.labelRegistroVenta.Text = "REGISTRO VENTAS";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEliminar.BackColor = System.Drawing.Color.Gray;
            this.buttonEliminar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(283, 206);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(115, 45);
            this.buttonEliminar.TabIndex = 94;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // button1Guar
            // 
            this.button1Guar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1Guar.BackColor = System.Drawing.Color.Gray;
            this.button1Guar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Guar.Location = new System.Drawing.Point(536, 206);
            this.button1Guar.Name = "button1Guar";
            this.button1Guar.Size = new System.Drawing.Size(115, 45);
            this.button1Guar.TabIndex = 96;
            this.button1Guar.Text = "Guardar";
            this.button1Guar.UseVisualStyleBackColor = false;
            this.button1Guar.Click += new System.EventHandler(this.button1Guar_Click);
            // 
            // button2Mod
            // 
            this.button2Mod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2Mod.BackColor = System.Drawing.Color.Gray;
            this.button2Mod.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Mod.Location = new System.Drawing.Point(412, 206);
            this.button2Mod.Name = "button2Mod";
            this.button2Mod.Size = new System.Drawing.Size(115, 45);
            this.button2Mod.TabIndex = 95;
            this.button2Mod.Text = "Modificar";
            this.button2Mod.UseVisualStyleBackColor = false;
            this.button2Mod.Click += new System.EventHandler(this.button2Mod_Click);
            // 
            // button1Rep
            // 
            this.button1Rep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1Rep.BackColor = System.Drawing.Color.Gray;
            this.button1Rep.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Rep.Location = new System.Drawing.Point(582, 331);
            this.button1Rep.Name = "button1Rep";
            this.button1Rep.Size = new System.Drawing.Size(90, 45);
            this.button1Rep.TabIndex = 97;
            this.button1Rep.Text = "Reporte";
            this.button1Rep.UseVisualStyleBackColor = false;
            this.button1Rep.Click += new System.EventHandler(this.button1Rep_Click);
            // 
            // FormRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.button1Rep);
            this.Controls.Add(this.button1Guar);
            this.Controls.Add(this.button2Mod);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dateTimePickerFechaFinVenta);
            this.Controls.Add(this.dateTimePickerFechaInicioVenta);
            this.Controls.Add(this.labelFechaFinVenta);
            this.Controls.Add(this.labelFechaInicioVenta);
            this.Controls.Add(this.labelVisualVentas);
            this.Controls.Add(this.dataGridViewVentas);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxNombreVenta);
            this.Controls.Add(this.labelNombreVenta);
            this.Controls.Add(this.labelNumeroCelularVenta);
            this.Controls.Add(this.textBoxNumeroCelularVenta);
            this.Controls.Add(this.labelIdVenta);
            this.Controls.Add(this.textBoxIdVenta);
            this.Controls.Add(this.ButttonRegistrar);
            this.Controls.Add(this.labelRegistroVenta);
            this.Name = "FormRegistrarVenta";
            this.Text = "FormRegistrarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinVenta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicioVenta;
        private System.Windows.Forms.Label labelFechaFinVenta;
        private System.Windows.Forms.Label labelFechaInicioVenta;
        private System.Windows.Forms.Label labelVisualVentas;
        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxNombreVenta;
        private System.Windows.Forms.Label labelNombreVenta;
        private System.Windows.Forms.Label labelNumeroCelularVenta;
        private System.Windows.Forms.TextBox textBoxNumeroCelularVenta;
        private System.Windows.Forms.Label labelIdVenta;
        private System.Windows.Forms.TextBox textBoxIdVenta;
        private System.Windows.Forms.Button ButttonRegistrar;
        private System.Windows.Forms.Label labelRegistroVenta;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button button1Guar;
        private System.Windows.Forms.Button button2Mod;
        private System.Windows.Forms.Button button1Rep;
    }
}