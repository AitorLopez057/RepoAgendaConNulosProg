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
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonosContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(101, 39);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(676, 301);
            this.dgvContactos.TabIndex = 15;
            // 
            // btnAltaContactos
            // 
            this.btnAltaContactos.Location = new System.Drawing.Point(132, 368);
            this.btnAltaContactos.Name = "btnAltaContactos";
            this.btnAltaContactos.Size = new System.Drawing.Size(120, 33);
            this.btnAltaContactos.TabIndex = 30;
            this.btnAltaContactos.Text = "Alta de contactos";
            this.btnAltaContactos.UseVisualStyleBackColor = true;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(613, 375);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(65, 20);
            this.txtNumeroTelefono.TabIndex = 29;
            this.txtNumeroTelefono.Text = "611111111";
            // 
            // btnContactosTelefono
            // 
            this.btnContactosTelefono.Location = new System.Drawing.Point(435, 369);
            this.btnContactosTelefono.Name = "btnContactosTelefono";
            this.btnContactosTelefono.Size = new System.Drawing.Size(143, 33);
            this.btnContactosTelefono.TabIndex = 28;
            this.btnContactosTelefono.Text = "Contactos de un teléfono";
            this.btnContactosTelefono.UseVisualStyleBackColor = true;
            // 
            // btnTodosContactos
            // 
            this.btnTodosContactos.Location = new System.Drawing.Point(278, 369);
            this.btnTodosContactos.Name = "btnTodosContactos";
            this.btnTodosContactos.Size = new System.Drawing.Size(120, 33);
            this.btnTodosContactos.TabIndex = 27;
            this.btnTodosContactos.Text = "Todos los contactos";
            this.btnTodosContactos.UseVisualStyleBackColor = true;
            // 
            // dgvTelefonosContacto
            // 
            this.dgvTelefonosContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonosContacto.Location = new System.Drawing.Point(404, 497);
            this.dgvTelefonosContacto.Name = "dgvTelefonosContacto";
            this.dgvTelefonosContacto.Size = new System.Drawing.Size(334, 125);
            this.dgvTelefonosContacto.TabIndex = 26;
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(278, 497);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(42, 20);
            this.txtIdContacto.TabIndex = 25;
            this.txtIdContacto.Text = "14";
            this.txtIdContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTelefonosContacto
            // 
            this.btnTelefonosContacto.Location = new System.Drawing.Point(114, 497);
            this.btnTelefonosContacto.Name = "btnTelefonosContacto";
            this.btnTelefonosContacto.Size = new System.Drawing.Size(138, 37);
            this.btnTelefonosContacto.TabIndex = 24;
            this.btnTelefonosContacto.Text = "Teléfonos de contacto";
            this.btnTelefonosContacto.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(99, 422);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(679, 38);
            this.lblMensaje.TabIndex = 23;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 644);
            this.Controls.Add(this.btnAltaContactos);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.btnContactosTelefono);
            this.Controls.Add(this.btnTodosContactos);
            this.Controls.Add(this.dgvTelefonosContacto);
            this.Controls.Add(this.txtIdContacto);
            this.Controls.Add(this.btnTelefonosContacto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dgvContactos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

