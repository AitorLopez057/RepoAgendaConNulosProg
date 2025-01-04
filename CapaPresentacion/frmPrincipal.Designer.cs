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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.btnContactosTelefono = new System.Windows.Forms.Button();
            this.btnTodosContactos = new System.Windows.Forms.Button();
            this.txtIdContacto = new System.Windows.Forms.TextBox();
            this.btnTelefonosContacto = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gboMantenimiento = new System.Windows.Forms.GroupBox();
            this.btnEditContacto = new System.Windows.Forms.Button();
            this.btnAnyadirTelefonoAContacto = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnDarAltaContacto = new System.Windows.Forms.Button();
            this.gboGrupos = new System.Windows.Forms.GroupBox();
            this.btnEditarGrupo = new System.Windows.Forms.Button();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.btnDarDeAltaUnGrupo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContactos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContactos.Location = new System.Drawing.Point(23, 67);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.Size = new System.Drawing.Size(811, 301);
            this.dgvContactos.TabIndex = 15;
            this.dgvContactos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellDoubleClick);
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(173, 32);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(65, 20);
            this.txtNumeroTelefono.TabIndex = 29;
            this.txtNumeroTelefono.Text = "611111111";
            this.txtNumeroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnContactosTelefono
            // 
            this.btnContactosTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContactosTelefono.Location = new System.Drawing.Point(15, 24);
            this.btnContactosTelefono.Name = "btnContactosTelefono";
            this.btnContactosTelefono.Size = new System.Drawing.Size(143, 33);
            this.btnContactosTelefono.TabIndex = 28;
            this.btnContactosTelefono.Text = "Contactos de un teléfono";
            this.btnContactosTelefono.UseVisualStyleBackColor = true;
            this.btnContactosTelefono.Click += new System.EventHandler(this.btnContactosTelefono_Click);
            // 
            // btnTodosContactos
            // 
            this.btnTodosContactos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosContactos.Location = new System.Drawing.Point(22, 24);
            this.btnTodosContactos.Name = "btnTodosContactos";
            this.btnTodosContactos.Size = new System.Drawing.Size(120, 33);
            this.btnTodosContactos.TabIndex = 27;
            this.btnTodosContactos.Text = "Todos los contactos";
            this.btnTodosContactos.UseVisualStyleBackColor = true;
            this.btnTodosContactos.Click += new System.EventHandler(this.btnTodosContactos_Click);
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(184, 32);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(42, 20);
            this.txtIdContacto.TabIndex = 25;
            this.txtIdContacto.Text = "14";
            this.txtIdContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTelefonosContacto
            // 
            this.btnTelefonosContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelefonosContacto.Location = new System.Drawing.Point(22, 23);
            this.btnTelefonosContacto.Name = "btnTelefonosContacto";
            this.btnTelefonosContacto.Size = new System.Drawing.Size(138, 37);
            this.btnTelefonosContacto.TabIndex = 24;
            this.btnTelefonosContacto.Text = "Teléfonos de contacto";
            this.btnTelefonosContacto.UseVisualStyleBackColor = true;
            this.btnTelefonosContacto.Click += new System.EventHandler(this.btnTelefonosContacto_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(23, 13);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(811, 38);
            this.lblMensaje.TabIndex = 23;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboMantenimiento
            // 
            this.gboMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gboMantenimiento.Controls.Add(this.btnEditContacto);
            this.gboMantenimiento.Controls.Add(this.btnAnyadirTelefonoAContacto);
            this.gboMantenimiento.Controls.Add(this.btnEliminarContacto);
            this.gboMantenimiento.Controls.Add(this.btnDarAltaContacto);
            this.gboMantenimiento.Location = new System.Drawing.Point(886, 67);
            this.gboMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.gboMantenimiento.Name = "gboMantenimiento";
            this.gboMantenimiento.Padding = new System.Windows.Forms.Padding(2);
            this.gboMantenimiento.Size = new System.Drawing.Size(418, 148);
            this.gboMantenimiento.TabIndex = 34;
            this.gboMantenimiento.TabStop = false;
            this.gboMantenimiento.Text = "Mantenimiento de Contactos";
            // 
            // btnEditContacto
            // 
            this.btnEditContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditContacto.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditContacto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditContacto.Location = new System.Drawing.Point(213, 28);
            this.btnEditContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditContacto.Name = "btnEditContacto";
            this.btnEditContacto.Size = new System.Drawing.Size(104, 40);
            this.btnEditContacto.TabIndex = 3;
            this.btnEditContacto.Text = "Editar un Contacto";
            this.btnEditContacto.UseVisualStyleBackColor = false;
            this.btnEditContacto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnyadirTelefonoAContacto
            // 
            this.btnAnyadirTelefonoAContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnyadirTelefonoAContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnyadirTelefonoAContacto.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnyadirTelefonoAContacto.Location = new System.Drawing.Point(213, 86);
            this.btnAnyadirTelefonoAContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnyadirTelefonoAContacto.Name = "btnAnyadirTelefonoAContacto";
            this.btnAnyadirTelefonoAContacto.Size = new System.Drawing.Size(154, 40);
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
            this.btnEliminarContacto.Location = new System.Drawing.Point(54, 86);
            this.btnEliminarContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(104, 40);
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
            this.btnDarAltaContacto.Location = new System.Drawing.Point(54, 28);
            this.btnDarAltaContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDarAltaContacto.Name = "btnDarAltaContacto";
            this.btnDarAltaContacto.Size = new System.Drawing.Size(104, 40);
            this.btnDarAltaContacto.TabIndex = 0;
            this.btnDarAltaContacto.Text = "Dar de alta un Contacto";
            this.btnDarAltaContacto.UseVisualStyleBackColor = false;
            this.btnDarAltaContacto.Click += new System.EventHandler(this.btnDarAltaContacto_Click);
            // 
            // gboGrupos
            // 
            this.gboGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gboGrupos.Controls.Add(this.btnEditarGrupo);
            this.gboGrupos.Controls.Add(this.btnEliminarGrupo);
            this.gboGrupos.Controls.Add(this.btnDarDeAltaUnGrupo);
            this.gboGrupos.Location = new System.Drawing.Point(886, 247);
            this.gboGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.gboGrupos.Name = "gboGrupos";
            this.gboGrupos.Padding = new System.Windows.Forms.Padding(2);
            this.gboGrupos.Size = new System.Drawing.Size(418, 120);
            this.gboGrupos.TabIndex = 35;
            this.gboGrupos.TabStop = false;
            this.gboGrupos.Text = "Mantenimiento de Grupos";
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditarGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarGrupo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditarGrupo.Location = new System.Drawing.Point(176, 47);
            this.btnEditarGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(104, 40);
            this.btnEditarGrupo.TabIndex = 5;
            this.btnEditarGrupo.Text = "Editar Grupo";
            this.btnEditarGrupo.UseVisualStyleBackColor = false;
            this.btnEditarGrupo.Click += new System.EventHandler(this.btnEditarGrupo_Click);
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarGrupo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarGrupo.Location = new System.Drawing.Point(298, 47);
            this.btnEliminarGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(104, 40);
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
            this.btnDarDeAltaUnGrupo.Location = new System.Drawing.Point(54, 47);
            this.btnDarDeAltaUnGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDarDeAltaUnGrupo.Name = "btnDarDeAltaUnGrupo";
            this.btnDarDeAltaUnGrupo.Size = new System.Drawing.Size(104, 40);
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
            this.groupBox1.Location = new System.Drawing.Point(584, 381);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(250, 77);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.btnTelefonosContacto);
            this.groupBox2.Controls.Add(this.txtIdContacto);
            this.groupBox2.Location = new System.Drawing.Point(266, 381);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(247, 77);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.btnTodosContactos);
            this.groupBox3.Location = new System.Drawing.Point(23, 381);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(166, 77);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(23, 465);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 259);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1370, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboGrupos);
            this.Controls.Add(this.gboMantenimiento);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dgvContactos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Text = "App Contactos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
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
        private System.Windows.Forms.Button btnEditContacto;
        private System.Windows.Forms.Button btnEditarGrupo;
        private System.Windows.Forms.Panel panel1;
    }
}

