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
            this.gboMantenimiento = new System.Windows.Forms.GroupBox();
            this.btnAnyadirTelefonoAContacto = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnDarAltaContacto = new System.Windows.Forms.Button();
            this.gboGrupos = new System.Windows.Forms.GroupBox();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.btnDarDeAltaUnGrupo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.gboMantenimiento.SuspendLayout();
            this.gboGrupos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.dgvContactos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellDoubleClick);
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(231, 40);
            this.txtNumeroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(85, 22);
            this.txtNumeroTelefono.TabIndex = 29;
            this.txtNumeroTelefono.Text = "611111111";
            this.txtNumeroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnContactosTelefono
            // 
            this.btnContactosTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContactosTelefono.Location = new System.Drawing.Point(20, 29);
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
            this.btnTodosContactos.Location = new System.Drawing.Point(30, 29);
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
            this.txtIdContacto.Location = new System.Drawing.Point(246, 40);
            this.txtIdContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(55, 22);
            this.txtIdContacto.TabIndex = 25;
            this.txtIdContacto.Text = "14";
            this.txtIdContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTelefonosContacto
            // 
            this.btnTelefonosContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelefonosContacto.Location = new System.Drawing.Point(30, 28);
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
            // gboMantenimiento
            // 
            this.gboMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gboMantenimiento.Controls.Add(this.btnAnyadirTelefonoAContacto);
            this.gboMantenimiento.Controls.Add(this.btnEliminarContacto);
            this.gboMantenimiento.Controls.Add(this.btnDarAltaContacto);
            this.gboMantenimiento.Location = new System.Drawing.Point(1181, 82);
            this.gboMantenimiento.Name = "gboMantenimiento";
            this.gboMantenimiento.Size = new System.Drawing.Size(557, 182);
            this.gboMantenimiento.TabIndex = 34;
            this.gboMantenimiento.TabStop = false;
            this.gboMantenimiento.Text = "Mantenimiento de Contactos";
            // 
            // btnAnyadirTelefonoAContacto
            // 
            this.btnAnyadirTelefonoAContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnyadirTelefonoAContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnyadirTelefonoAContacto.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnyadirTelefonoAContacto.Location = new System.Drawing.Point(317, 70);
            this.btnAnyadirTelefonoAContacto.Name = "btnAnyadirTelefonoAContacto";
            this.btnAnyadirTelefonoAContacto.Size = new System.Drawing.Size(206, 49);
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
            this.btnEliminarContacto.Location = new System.Drawing.Point(72, 106);
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
            // gboGrupos
            // 
            this.gboGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gboGrupos.Controls.Add(this.btnEliminarGrupo);
            this.gboGrupos.Controls.Add(this.btnDarDeAltaUnGrupo);
            this.gboGrupos.Location = new System.Drawing.Point(1181, 304);
            this.gboGrupos.Name = "gboGrupos";
            this.gboGrupos.Size = new System.Drawing.Size(557, 148);
            this.gboGrupos.TabIndex = 35;
            this.gboGrupos.TabStop = false;
            this.gboGrupos.Text = "Mantenimiento de Grupos";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnContactosTelefono);
            this.groupBox1.Controls.Add(this.txtNumeroTelefono);
            this.groupBox1.Location = new System.Drawing.Point(778, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 95);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.btnTelefonosContacto);
            this.groupBox2.Controls.Add(this.txtIdContacto);
            this.groupBox2.Location = new System.Drawing.Point(355, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 95);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.btnTodosContactos);
            this.groupBox3.Location = new System.Drawing.Point(31, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 95);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1777, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboGrupos);
            this.Controls.Add(this.gboMantenimiento);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dgvContactos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "App Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.gboMantenimiento.ResumeLayout(false);
            this.gboGrupos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Button btnContactosTelefono;
        private System.Windows.Forms.Button btnTodosContactos;
        private System.Windows.Forms.TextBox txtIdContacto;
        private System.Windows.Forms.Button btnTelefonosContacto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.GroupBox gboMantenimiento;
        private System.Windows.Forms.Button btnAnyadirTelefonoAContacto;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnDarAltaContacto;
        private System.Windows.Forms.GroupBox gboGrupos;
        private System.Windows.Forms.Button btnEliminarGrupo;
        private System.Windows.Forms.Button btnDarDeAltaUnGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

