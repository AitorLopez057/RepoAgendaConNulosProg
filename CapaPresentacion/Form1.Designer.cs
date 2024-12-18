namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.btnAltaContactos = new System.Windows.Forms.Button();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.btnContactosTelefono = new System.Windows.Forms.Button();
            this.btnTodosContactos = new System.Windows.Forms.Button();
            this.dgvTelefonosContacto = new System.Windows.Forms.DataGridView();
            this.txtIdContacto = new System.Windows.Forms.TextBox();
            this.btnTelefonosContacto = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.btnAñadirTelefonoContacto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonosContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(135, 48);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.Size = new System.Drawing.Size(901, 370);
            this.dgvContactos.TabIndex = 15;
            // 
            // btnAltaContactos
            // 
            this.btnAltaContactos.Location = new System.Drawing.Point(176, 453);
            this.btnAltaContactos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltaContactos.Name = "btnAltaContactos";
            this.btnAltaContactos.Size = new System.Drawing.Size(160, 41);
            this.btnAltaContactos.TabIndex = 30;
            this.btnAltaContactos.Text = "Alta de contactos";
            this.btnAltaContactos.UseVisualStyleBackColor = true;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(817, 462);
            this.txtNumeroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(85, 22);
            this.txtNumeroTelefono.TabIndex = 29;
            this.txtNumeroTelefono.Text = "611111111";
            // 
            // btnContactosTelefono
            // 
            this.btnContactosTelefono.Location = new System.Drawing.Point(580, 454);
            this.btnContactosTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.btnContactosTelefono.Name = "btnContactosTelefono";
            this.btnContactosTelefono.Size = new System.Drawing.Size(191, 41);
            this.btnContactosTelefono.TabIndex = 28;
            this.btnContactosTelefono.Text = "Contactos de un teléfono";
            this.btnContactosTelefono.UseVisualStyleBackColor = true;
            // 
            // btnTodosContactos
            // 
            this.btnTodosContactos.Location = new System.Drawing.Point(371, 454);
            this.btnTodosContactos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTodosContactos.Name = "btnTodosContactos";
            this.btnTodosContactos.Size = new System.Drawing.Size(160, 41);
            this.btnTodosContactos.TabIndex = 27;
            this.btnTodosContactos.Text = "Todos los contactos";
            this.btnTodosContactos.UseVisualStyleBackColor = true;
            this.btnTodosContactos.Click += new System.EventHandler(this.btnTodosContactos_Click);
            // 
            // dgvTelefonosContacto
            // 
            this.dgvTelefonosContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonosContacto.Location = new System.Drawing.Point(443, 612);
            this.dgvTelefonosContacto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTelefonosContacto.Name = "dgvTelefonosContacto";
            this.dgvTelefonosContacto.RowHeadersWidth = 51;
            this.dgvTelefonosContacto.Size = new System.Drawing.Size(445, 154);
            this.dgvTelefonosContacto.TabIndex = 26;
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(371, 612);
            this.txtIdContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(55, 22);
            this.txtIdContacto.TabIndex = 25;
            this.txtIdContacto.Text = "14";
            this.txtIdContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTelefonosContacto
            // 
            this.btnTelefonosContacto.Location = new System.Drawing.Point(152, 612);
            this.btnTelefonosContacto.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelefonosContacto.Name = "btnTelefonosContacto";
            this.btnTelefonosContacto.Size = new System.Drawing.Size(184, 46);
            this.btnTelefonosContacto.TabIndex = 24;
            this.btnTelefonosContacto.Text = "Teléfonos de contacto";
            this.btnTelefonosContacto.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(132, 519);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(905, 47);
            this.lblMensaje.TabIndex = 23;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(935, 611);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(220, 47);
            this.btnBorrar.TabIndex = 31;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.Location = new System.Drawing.Point(935, 664);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(220, 47);
            this.btnDarAlta.TabIndex = 32;
            this.btnDarAlta.Text = "Dar de Alta";
            this.btnDarAlta.UseVisualStyleBackColor = true;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // btnAñadirTelefonoContacto
            // 
            this.btnAñadirTelefonoContacto.Location = new System.Drawing.Point(935, 719);
            this.btnAñadirTelefonoContacto.Name = "btnAñadirTelefonoContacto";
            this.btnAñadirTelefonoContacto.Size = new System.Drawing.Size(220, 47);
            this.btnAñadirTelefonoContacto.TabIndex = 33;
            this.btnAñadirTelefonoContacto.Text = "Añadir Telefono a Conacto";
            this.btnAñadirTelefonoContacto.UseVisualStyleBackColor = true;
            this.btnAñadirTelefonoContacto.Click += new System.EventHandler(this.btnAñadirTelefonoContacto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 793);
            this.Controls.Add(this.btnAñadirTelefonoContacto);
            this.Controls.Add(this.btnDarAlta);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAltaContactos);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.btnContactosTelefono);
            this.Controls.Add(this.btnTodosContactos);
            this.Controls.Add(this.dgvTelefonosContacto);
            this.Controls.Add(this.txtIdContacto);
            this.Controls.Add(this.btnTelefonosContacto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dgvContactos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonosContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Button btnAltaContactos;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Button btnContactosTelefono;
        private System.Windows.Forms.Button btnTodosContactos;
        private System.Windows.Forms.DataGridView dgvTelefonosContacto;
        private System.Windows.Forms.TextBox txtIdContacto;
        private System.Windows.Forms.Button btnTelefonosContacto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.Button btnAñadirTelefonoContacto;
    }
}

