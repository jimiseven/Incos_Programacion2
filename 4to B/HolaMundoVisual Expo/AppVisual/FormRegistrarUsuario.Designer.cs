namespace AppVisual
{
    partial class FormRegistrarUsuario
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
            this.labelVisualUsuarios = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxNumCelularUsuario = new System.Windows.Forms.TextBox();
            this.labelNumCelularUsuario = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.labelIdUsuario = new System.Windows.Forms.Label();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.ButttonRegistrar = new System.Windows.Forms.Button();
            this.labelRegistroUsuarios = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVisualUsuarios
            // 
            this.labelVisualUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVisualUsuarios.AutoSize = true;
            this.labelVisualUsuarios.BackColor = System.Drawing.Color.White;
            this.labelVisualUsuarios.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisualUsuarios.ForeColor = System.Drawing.Color.Black;
            this.labelVisualUsuarios.Location = new System.Drawing.Point(277, 244);
            this.labelVisualUsuarios.Name = "labelVisualUsuarios";
            this.labelVisualUsuarios.Size = new System.Drawing.Size(130, 19);
            this.labelVisualUsuarios.TabIndex = 47;
            this.labelVisualUsuarios.Text = "Lista de Usuarios ";
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(90, 266);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(508, 150);
            this.dataGridViewUsuarios.TabIndex = 46;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLimpiar.BackColor = System.Drawing.Color.Gray;
            this.buttonLimpiar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(378, 162);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(130, 45);
            this.buttonLimpiar.TabIndex = 45;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxNumCelularUsuario
            // 
            this.textBoxNumCelularUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumCelularUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumCelularUsuario.Location = new System.Drawing.Point(238, 180);
            this.textBoxNumCelularUsuario.Name = "textBoxNumCelularUsuario";
            this.textBoxNumCelularUsuario.Size = new System.Drawing.Size(100, 27);
            this.textBoxNumCelularUsuario.TabIndex = 44;
            // 
            // labelNumCelularUsuario
            // 
            this.labelNumCelularUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumCelularUsuario.AutoSize = true;
            this.labelNumCelularUsuario.BackColor = System.Drawing.Color.White;
            this.labelNumCelularUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCelularUsuario.ForeColor = System.Drawing.Color.Black;
            this.labelNumCelularUsuario.Location = new System.Drawing.Point(86, 188);
            this.labelNumCelularUsuario.Name = "labelNumCelularUsuario";
            this.labelNumCelularUsuario.Size = new System.Drawing.Size(137, 19);
            this.labelNumCelularUsuario.TabIndex = 43;
            this.labelNumCelularUsuario.Text = "Numero de Celular";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.BackColor = System.Drawing.Color.White;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNombreUsuario.Location = new System.Drawing.Point(86, 132);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(124, 19);
            this.labelNombreUsuario.TabIndex = 42;
            this.labelNombreUsuario.Text = "Nombre Usuario";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(238, 132);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(100, 27);
            this.textBoxNombreUsuario.TabIndex = 41;
            // 
            // labelIdUsuario
            // 
            this.labelIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIdUsuario.AutoSize = true;
            this.labelIdUsuario.BackColor = System.Drawing.Color.White;
            this.labelIdUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdUsuario.Location = new System.Drawing.Point(86, 83);
            this.labelIdUsuario.Name = "labelIdUsuario";
            this.labelIdUsuario.Size = new System.Drawing.Size(79, 19);
            this.labelIdUsuario.TabIndex = 40;
            this.labelIdUsuario.Text = "id Usuario";
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIdUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdUsuario.Location = new System.Drawing.Point(238, 83);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(100, 27);
            this.textBoxIdUsuario.TabIndex = 39;
            // 
            // ButttonRegistrar
            // 
            this.ButttonRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButttonRegistrar.BackColor = System.Drawing.Color.Gray;
            this.ButttonRegistrar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButttonRegistrar.Location = new System.Drawing.Point(378, 83);
            this.ButttonRegistrar.Name = "ButttonRegistrar";
            this.ButttonRegistrar.Size = new System.Drawing.Size(130, 45);
            this.ButttonRegistrar.TabIndex = 38;
            this.ButttonRegistrar.Text = "Registrar";
            this.ButttonRegistrar.UseVisualStyleBackColor = false;
            this.ButttonRegistrar.Click += new System.EventHandler(this.ButttonRegistrar_Click);
            // 
            // labelRegistroUsuarios
            // 
            this.labelRegistroUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegistroUsuarios.AutoSize = true;
            this.labelRegistroUsuarios.BackColor = System.Drawing.Color.White;
            this.labelRegistroUsuarios.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegistroUsuarios.Location = new System.Drawing.Point(265, 33);
            this.labelRegistroUsuarios.Name = "labelRegistroUsuarios";
            this.labelRegistroUsuarios.Size = new System.Drawing.Size(163, 19);
            this.labelRegistroUsuarios.TabIndex = 37;
            this.labelRegistroUsuarios.Text = "REGISTRO USUARIOS";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEliminar.BackColor = System.Drawing.Color.Gray;
            this.buttonEliminar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(531, 122);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(130, 45);
            this.buttonEliminar.TabIndex = 57;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // FormRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelVisualUsuarios);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxNumCelularUsuario);
            this.Controls.Add(this.labelNumCelularUsuario);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.labelIdUsuario);
            this.Controls.Add(this.textBoxIdUsuario);
            this.Controls.Add(this.ButttonRegistrar);
            this.Controls.Add(this.labelRegistroUsuarios);
            this.Name = "FormRegistrarUsuario";
            this.Text = "FormRegistrarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVisualUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxNumCelularUsuario;
        private System.Windows.Forms.Label labelNumCelularUsuario;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label labelIdUsuario;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.Button ButttonRegistrar;
        private System.Windows.Forms.Label labelRegistroUsuarios;
        private System.Windows.Forms.Button buttonEliminar;
    }
}