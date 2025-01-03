namespace CapaPresentacion
{
    partial class frmDarAltaContacto
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
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadirContacto = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAñadirTelefono = new System.Windows.Forms.Button();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBTelefono = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(381, 109);
            this.txtNombreContacto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(198, 20);
            this.txtNombreContacto.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(303, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // btnAñadirContacto
            // 
            this.btnAñadirContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAñadirContacto.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAñadirContacto.Location = new System.Drawing.Point(307, 336);
            this.btnAñadirContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirContacto.Name = "btnAñadirContacto";
            this.btnAñadirContacto.Size = new System.Drawing.Size(154, 41);
            this.btnAñadirContacto.TabIndex = 14;
            this.btnAñadirContacto.Text = "Crear Contacto";
            this.btnAñadirContacto.UseVisualStyleBackColor = false;
            this.btnAñadirContacto.Click += new System.EventHandler(this.btnAñadirContacto_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblResultado.Location = new System.Drawing.Point(303, 12);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(428, 37);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(303, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Grupo";
            // 
            // txtDescripcionTelefono
            // 
            this.txtDescripcionTelefono.Location = new System.Drawing.Point(158, 72);
            this.txtDescripcionTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionTelefono.Name = "txtDescripcionTelefono";
            this.txtDescripcionTelefono.Size = new System.Drawing.Size(233, 20);
            this.txtDescripcionTelefono.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Descripción";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(158, 43);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(233, 20);
            this.txtTelefono.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(16, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Numero de Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(71, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Telefonos del Contacto";
            // 
            // btnAñadirTelefono
            // 
            this.btnAñadirTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAñadirTelefono.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAñadirTelefono.Location = new System.Drawing.Point(19, 103);
            this.btnAñadirTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirTelefono.Name = "btnAñadirTelefono";
            this.btnAñadirTelefono.Size = new System.Drawing.Size(263, 37);
            this.btnAñadirTelefono.TabIndex = 29;
            this.btnAñadirTelefono.Text = "Añadir Teléfono al contacto";
            this.btnAñadirTelefono.UseVisualStyleBackColor = false;
            this.btnAñadirTelefono.Click += new System.EventHandler(this.btnAñadirTelefono_Click);
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(381, 132);
            this.cboGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(198, 21);
            this.cboGrupo.TabIndex = 30;
            this.cboGrupo.SelectedIndexChanged += new System.EventHandler(this.cboGrupo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(279, 400);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBTelefono
            // 
            this.lblBTelefono.AutoSize = true;
            this.lblBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBTelefono.Location = new System.Drawing.Point(302, 63);
            this.lblBTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBTelefono.Name = "lblBTelefono";
            this.lblBTelefono.Size = new System.Drawing.Size(189, 25);
            this.lblBTelefono.TabIndex = 36;
            this.lblBTelefono.Text = "Crear un Contacto";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnAñadirTelefono);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDescripcionTelefono);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(306, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(424, 154);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // frmDarAltaContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblBTelefono);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAñadirContacto);
            this.Controls.Add(this.lblResultado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDarAltaContacto";
            this.Text = "DarAlta";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAñadirContacto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAñadirTelefono;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBTelefono;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}