namespace AppVisual
{
    partial class FormRegistrarCliente
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxNumCelular = new System.Windows.Forms.TextBox();
            this.labelNumCelularCliente = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.ButttonRegistrar = new System.Windows.Forms.Button();
            this.labelRegistroClientes = new System.Windows.Forms.Label();
            this.labelVisualClientes = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(74, 242);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClientes.Size = new System.Drawing.Size(508, 150);
            this.dataGridViewClientes.TabIndex = 35;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.BackColor = System.Drawing.Color.Gray;
            this.buttonLimpiar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(360, 138);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(130, 45);
            this.buttonLimpiar.TabIndex = 32;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxNumCelular
            // 
            this.textBoxNumCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumCelular.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumCelular.Location = new System.Drawing.Point(222, 156);
            this.textBoxNumCelular.Name = "textBoxNumCelular";
            this.textBoxNumCelular.Size = new System.Drawing.Size(100, 27);
            this.textBoxNumCelular.TabIndex = 29;
            // 
            // labelNumCelularCliente
            // 
            this.labelNumCelularCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumCelularCliente.AutoSize = true;
            this.labelNumCelularCliente.BackColor = System.Drawing.Color.White;
            this.labelNumCelularCliente.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCelularCliente.ForeColor = System.Drawing.Color.Black;
            this.labelNumCelularCliente.Location = new System.Drawing.Point(70, 164);
            this.labelNumCelularCliente.Name = "labelNumCelularCliente";
            this.labelNumCelularCliente.Size = new System.Drawing.Size(137, 19);
            this.labelNumCelularCliente.TabIndex = 26;
            this.labelNumCelularCliente.Text = "Numero de Celular";
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.BackColor = System.Drawing.Color.White;
            this.labelNombreCliente.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNombreCliente.Location = new System.Drawing.Point(70, 108);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(117, 19);
            this.labelNombreCliente.TabIndex = 25;
            this.labelNombreCliente.Text = "Nombre Cliente";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(222, 108);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 27);
            this.textBoxNombre.TabIndex = 24;
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.BackColor = System.Drawing.Color.White;
            this.labelIdCliente.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdCliente.Location = new System.Drawing.Point(70, 59);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(72, 19);
            this.labelIdCliente.TabIndex = 23;
            this.labelIdCliente.Text = "id Cliente";
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdCliente.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdCliente.Location = new System.Drawing.Point(222, 59);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(100, 27);
            this.textBoxIdCliente.TabIndex = 22;
            // 
            // ButttonRegistrar
            // 
            this.ButttonRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButttonRegistrar.BackColor = System.Drawing.Color.Gray;
            this.ButttonRegistrar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButttonRegistrar.Location = new System.Drawing.Point(360, 59);
            this.ButttonRegistrar.Name = "ButttonRegistrar";
            this.ButttonRegistrar.Size = new System.Drawing.Size(130, 45);
            this.ButttonRegistrar.TabIndex = 21;
            this.ButttonRegistrar.Text = "Registrar";
            this.ButttonRegistrar.UseVisualStyleBackColor = false;
            this.ButttonRegistrar.Click += new System.EventHandler(this.ButttonRegistrar_Click);
            // 
            // labelRegistroClientes
            // 
            this.labelRegistroClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegistroClientes.AutoSize = true;
            this.labelRegistroClientes.BackColor = System.Drawing.Color.White;
            this.labelRegistroClientes.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegistroClientes.Location = new System.Drawing.Point(249, 9);
            this.labelRegistroClientes.Name = "labelRegistroClientes";
            this.labelRegistroClientes.Size = new System.Drawing.Size(155, 19);
            this.labelRegistroClientes.TabIndex = 20;
            this.labelRegistroClientes.Text = "REGISTRO CLIENTES";
            // 
            // labelVisualClientes
            // 
            this.labelVisualClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVisualClientes.AutoSize = true;
            this.labelVisualClientes.BackColor = System.Drawing.Color.White;
            this.labelVisualClientes.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisualClientes.ForeColor = System.Drawing.Color.Black;
            this.labelVisualClientes.Location = new System.Drawing.Point(261, 220);
            this.labelVisualClientes.Name = "labelVisualClientes";
            this.labelVisualClientes.Size = new System.Drawing.Size(120, 19);
            this.labelVisualClientes.TabIndex = 36;
            this.labelVisualClientes.Text = "Lista de Clientes";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.Color.Gray;
            this.buttonEliminar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(515, 59);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(130, 45);
            this.buttonEliminar.TabIndex = 38;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImprimir.BackColor = System.Drawing.Color.Gray;
            this.buttonImprimir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Location = new System.Drawing.Point(515, 124);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(130, 73);
            this.buttonImprimir.TabIndex = 39;
            this.buttonImprimir.Text = "Generar \r\nReporte";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // FormRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelVisualClientes);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxNumCelular);
            this.Controls.Add(this.labelNumCelularCliente);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelIdCliente);
            this.Controls.Add(this.textBoxIdCliente);
            this.Controls.Add(this.ButttonRegistrar);
            this.Controls.Add(this.labelRegistroClientes);
            this.Name = "FormRegistrarCliente";
            this.Text = "FormRegistrarCliente";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxNumCelular;
        private System.Windows.Forms.Label labelNumCelularCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.Button ButttonRegistrar;
        private System.Windows.Forms.Label labelRegistroClientes;
        private System.Windows.Forms.Label labelVisualClientes;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonImprimir;
    }
}