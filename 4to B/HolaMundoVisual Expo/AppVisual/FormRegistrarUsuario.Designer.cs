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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1Guar = new System.Windows.Forms.Button();
            this.button2Mod = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(90, 266);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(508, 150);
            this.dataGridViewUsuarios.TabIndex = 46;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLimpiar.BackColor = System.Drawing.Color.Gray;
            this.buttonLimpiar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(378, 134);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(130, 40);
            this.buttonLimpiar.TabIndex = 45;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxNumCelularUsuario
            // 
            this.textBoxNumCelularUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumCelularUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumCelularUsuario.Location = new System.Drawing.Point(238, 193);
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
            this.labelNumCelularUsuario.Location = new System.Drawing.Point(86, 201);
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
            this.labelNombreUsuario.Location = new System.Drawing.Point(86, 145);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(124, 19);
            this.labelNombreUsuario.TabIndex = 42;
            this.labelNombreUsuario.Text = "Nombre Usuario";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(238, 145);
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
            this.labelIdUsuario.Location = new System.Drawing.Point(86, 96);
            this.labelIdUsuario.Name = "labelIdUsuario";
            this.labelIdUsuario.Size = new System.Drawing.Size(79, 19);
            this.labelIdUsuario.TabIndex = 40;
            this.labelIdUsuario.Text = "id Usuario";
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIdUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdUsuario.Location = new System.Drawing.Point(238, 96);
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
            this.ButttonRegistrar.Size = new System.Drawing.Size(130, 40);
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
            this.buttonEliminar.Location = new System.Drawing.Point(378, 190);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(130, 40);
            this.buttonEliminar.TabIndex = 57;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // button1Guar
            // 
            this.button1Guar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1Guar.BackColor = System.Drawing.Color.Gray;
            this.button1Guar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Guar.Location = new System.Drawing.Point(529, 134);
            this.button1Guar.Name = "button1Guar";
            this.button1Guar.Size = new System.Drawing.Size(130, 40);
            this.button1Guar.TabIndex = 59;
            this.button1Guar.Text = "Guardar";
            this.button1Guar.UseVisualStyleBackColor = false;
            this.button1Guar.Click += new System.EventHandler(this.button1Guar_Click);
            // 
            // button2Mod
            // 
            this.button2Mod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2Mod.BackColor = System.Drawing.Color.Gray;
            this.button2Mod.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Mod.Location = new System.Drawing.Point(529, 83);
            this.button2Mod.Name = "button2Mod";
            this.button2Mod.Size = new System.Drawing.Size(130, 40);
            this.button2Mod.TabIndex = 58;
            this.button2Mod.Text = "Modificar";
            this.button2Mod.UseVisualStyleBackColor = false;
            this.button2Mod.Click += new System.EventHandler(this.button2Mod_Click);
            // 
            // FormRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.button1Guar);
            this.Controls.Add(this.button2Mod);
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
        private System.Windows.Forms.Button button1Guar;
        private System.Windows.Forms.Button button2Mod;
    }
}