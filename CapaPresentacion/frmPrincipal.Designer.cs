namespace CapaPresentacion
{
    partial class frmPrincipal
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
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.btnContactosTelefono = new System.Windows.Forms.Button();
            this.btnTodosContactos = new System.Windows.Forms.Button();
            this.txtIdContacto = new System.Windows.Forms.TextBox();
            this.btnTelefonosContacto = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.btnAnyadirTelefonoAContacto = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnDarAltaContacto = new System.Windows.Forms.Button();
            this.gbGrupos = new System.Windows.Forms.GroupBox();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.btnDarDeAltaUnGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.gbMantenimiento.SuspendLayout();
            this.gbGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContactos
            // 
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(31, 82);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.Size = new System.Drawing.Size(1081, 370);
            this.dgvContactos.TabIndex = 15;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(900, 478);
            this.txtNumeroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(85, 22);
            this.txtNumeroTelefono.TabIndex = 29;
            this.txtNumeroTelefono.Text = "611111111";
            // 
            // btnContactosTelefono
            // 
            this.btnContactosTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContactosTelefono.Location = new System.Drawing.Point(687, 469);
            this.btnContactosTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.btnContactosTelefono.Name = "btnContactosTelefono";
            this.btnContactosTelefono.Size = new System.Drawing.Size(191, 41);
            this.btnContactosTelefono.TabIndex = 28;
            this.btnContactosTelefono.Text = "Contactos de un teléfono";
            this.btnContactosTelefono.UseVisualStyleBackColor = true;
            this.btnContactosTelefono.Click += new System.EventHandler(this.btnContactosTelefono_Click);
            // 
            // btnTodosContactos
            // 
            this.btnTodosContactos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosContactos.Location = new System.Drawing.Point(124, 469);
            this.btnTodosContactos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTodosContactos.Name = "btnTodosContactos";
            this.btnTodosContactos.Size = new System.Drawing.Size(160, 41);
            this.btnTodosContactos.TabIndex = 27;
            this.btnTodosContactos.Text = "Todos los contactos";
            this.btnTodosContactos.UseVisualStyleBackColor = true;
            this.btnTodosContactos.Click += new System.EventHandler(this.btnTodosContactos_Click);
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(576, 478);
            this.txtIdContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(55, 22);
            this.txtIdContacto.TabIndex = 25;
            this.txtIdContacto.Text = "14";
            this.txtIdContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTelefonosContacto
            // 
            this.btnTelefonosContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelefonosContacto.Location = new System.Drawing.Point(371, 464);
            this.btnTelefonosContacto.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelefonosContacto.Name = "btnTelefonosContacto";
            this.btnTelefonosContacto.Size = new System.Drawing.Size(184, 46);
            this.btnTelefonosContacto.TabIndex = 24;
            this.btnTelefonosContacto.Text = "Teléfonos de contacto";
            this.btnTelefonosContacto.UseVisualStyleBackColor = true;
            this.btnTelefonosContacto.Click += new System.EventHandler(this.btnTelefonosContacto_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(31, 16);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(1081, 47);
            this.lblMensaje.TabIndex = 23;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbMantenimiento.Controls.Add(this.btnAnyadirTelefonoAContacto);
            this.gbMantenimiento.Controls.Add(this.btnEliminarContacto);
            this.gbMantenimiento.Controls.Add(this.btnDarAltaContacto);
            this.gbMantenimiento.Location = new System.Drawing.Point(1181, 82);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(557, 182);
            this.gbMantenimiento.TabIndex = 34;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimiento de Contactos";
            // 
            // btnAnyadirTelefonoAContacto
            // 
            this.btnAnyadirTelefonoAContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnyadirTelefonoAContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnyadirTelefonoAContacto.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnyadirTelefonoAContacto.Location = new System.Drawing.Point(333, 59);
            this.btnAnyadirTelefonoAContacto.Name = "btnAnyadirTelefonoAContacto";
            this.btnAnyadirTelefonoAContacto.Size = new System.Drawing.Size(169, 77);
            this.btnAnyadirTelefonoAContacto.TabIndex = 2;
            this.btnAnyadirTelefonoAContacto.Text = "Añadir/Borrar un teléfono de un contacto";
            this.btnAnyadirTelefonoAContacto.UseVisualStyleBackColor = false;
            this.btnAnyadirTelefonoAContacto.Click += new System.EventHandler(this.btnAnyadirTelefonoAContacto_Click);
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarContacto.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarContacto.Location = new System.Drawing.Point(72, 108);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(138, 49);
            this.btnEliminarContacto.TabIndex = 1;
            this.btnEliminarContacto.Text = "Eliminar un Contacto";
            this.btnEliminarContacto.UseVisualStyleBackColor = false;
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnDarAltaContacto
            // 
            this.btnDarAltaContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDarAltaContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarAltaContacto.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarAltaContacto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDarAltaContacto.Location = new System.Drawing.Point(72, 35);
            this.btnDarAltaContacto.Name = "btnDarAltaContacto";
            this.btnDarAltaContacto.Size = new System.Drawing.Size(138, 49);
            this.btnDarAltaContacto.TabIndex = 0;
            this.btnDarAltaContacto.Text = "Dar de alta un Contacto";
            this.btnDarAltaContacto.UseVisualStyleBackColor = false;
            this.btnDarAltaContacto.Click += new System.EventHandler(this.btnDarAltaContacto_Click);
            // 
            // gbGrupos
            // 
            this.gbGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbGrupos.Controls.Add(this.btnEliminarGrupo);
            this.gbGrupos.Controls.Add(this.btnDarDeAltaUnGrupo);
            this.gbGrupos.Location = new System.Drawing.Point(1181, 304);
            this.gbGrupos.Name = "gbGrupos";
            this.gbGrupos.Size = new System.Drawing.Size(557, 148);
            this.gbGrupos.TabIndex = 35;
            this.gbGrupos.TabStop = false;
            this.gbGrupos.Text = "Mantenimiento de Grupos";
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarGrupo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarGrupo.Location = new System.Drawing.Point(351, 58);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(138, 49);
            this.btnEliminarGrupo.TabIndex = 3;
            this.btnEliminarGrupo.Text = "Eliminar un Grupo";
            this.btnEliminarGrupo.UseVisualStyleBackColor = false;
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // btnDarDeAltaUnGrupo
            // 
            this.btnDarDeAltaUnGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDarDeAltaUnGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarDeAltaUnGrupo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDarDeAltaUnGrupo.Location = new System.Drawing.Point(72, 58);
            this.btnDarDeAltaUnGrupo.Name = "btnDarDeAltaUnGrupo";
            this.btnDarDeAltaUnGrupo.Size = new System.Drawing.Size(138, 49);
            this.btnDarDeAltaUnGrupo.TabIndex = 3;
            this.btnDarDeAltaUnGrupo.Text = "Dar de alta un  Grupo";
            this.btnDarDeAltaUnGrupo.UseVisualStyleBackColor = false;
            this.btnDarDeAltaUnGrupo.Click += new System.EventHandler(this.btnDarDeAltaUnGrupo_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1777, 612);
            this.Controls.Add(this.gbGrupos);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.btnContactosTelefono);
            this.Controls.Add(this.btnTodosContactos);
            this.Controls.Add(this.txtIdContacto);
            this.Controls.Add(this.btnTelefonosContacto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dgvContactos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "App Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.gbMantenimiento.ResumeLayout(false);
            this.gbGrupos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Button btnContactosTelefono;
        private System.Windows.Forms.Button btnTodosContactos;
        private System.Windows.Forms.TextBox txtIdContacto;
        private System.Windows.Forms.Button btnTelefonosContacto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.Button btnAnyadirTelefonoAContacto;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnDarAltaContacto;
        private System.Windows.Forms.GroupBox gbGrupos;
        private System.Windows.Forms.Button btnEliminarGrupo;
        private System.Windows.Forms.Button btnDarDeAltaUnGrupo;
    }
}

