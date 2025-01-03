namespace CapaPresentacion
{
    partial class frmEditarContacto
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
            this.lblBTelefono = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarContacto = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailNuevo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboContactos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBTelefono
            // 
            this.lblBTelefono.AutoSize = true;
            this.lblBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBTelefono.Location = new System.Drawing.Point(80, 55);
            this.lblBTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBTelefono.Name = "lblBTelefono";
            this.lblBTelefono.Size = new System.Drawing.Size(191, 25);
            this.lblBTelefono.TabIndex = 44;
            this.lblBTelefono.Text = "Editar un Contacto";
            this.lblBTelefono.Click += new System.EventHandler(this.lblBTelefono_Click);
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(232, 256);
            this.cboGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(198, 21);
            this.cboGrupo.TabIndex = 43;
            this.cboGrupo.SelectedIndexChanged += new System.EventHandler(this.cboGrupo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(125, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cambiar grupo";
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(232, 189);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(198, 20);
            this.txtNombreNuevo.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(124, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre Nuevo";
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditarContacto.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditarContacto.Location = new System.Drawing.Point(203, 316);
            this.btnEditarContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Size = new System.Drawing.Size(154, 41);
            this.btnEditarContacto.TabIndex = 39;
            this.btnEditarContacto.Text = "Confirmar";
            this.btnEditarContacto.UseVisualStyleBackColor = false;
            this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblResultado.Location = new System.Drawing.Point(82, 8);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(428, 37);
            this.lblResultado.TabIndex = 38;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(124, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Email Nuevo";
            // 
            // txtEmailNuevo
            // 
            this.txtEmailNuevo.Location = new System.Drawing.Point(232, 221);
            this.txtEmailNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailNuevo.Name = "txtEmailNuevo";
            this.txtEmailNuevo.Size = new System.Drawing.Size(198, 20);
            this.txtEmailNuevo.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(82, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Elige el contacto que deseas editar";
            // 
            // cboContactos
            // 
            this.cboContactos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContactos.FormattingEnabled = true;
            this.cboContactos.Location = new System.Drawing.Point(83, 122);
            this.cboContactos.Margin = new System.Windows.Forms.Padding(2);
            this.cboContactos.Name = "cboContactos";
            this.cboContactos.Size = new System.Drawing.Size(227, 21);
            this.cboContactos.TabIndex = 49;
            this.cboContactos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(401, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 50;
            // 
            // frmEditarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboContactos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmailNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBTelefono);
            this.Controls.Add(this.cboGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditarContacto);
            this.Controls.Add(this.lblResultado);
            this.Name = "frmEditarContacto";
            this.Text = "frmEditarContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBTelefono;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarContacto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailNuevo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboContactos;
        private System.Windows.Forms.Label label8;
    }
}