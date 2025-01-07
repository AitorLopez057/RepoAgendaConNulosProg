namespace CapaPresentacion
{
    partial class frmEditarGrupo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditarGrupo = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.rbtnContactoCard = new System.Windows.Forms.RadioButton();
            this.btnSacarContacto = new System.Windows.Forms.Button();
            this.lstContactos = new System.Windows.Forms.ListBox();
            this.btnAñadirContacto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbGrupos = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbContactosDeGrupo = new System.Windows.Forms.ListBox();
            this.lblBTelefono = new System.Windows.Forms.Label();
            this.rbtnContactoLista = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(36, 564);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 219);
            this.panel1.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnEditarGrupo);
            this.groupBox3.Controls.Add(this.txtNuevoNombre);
            this.groupBox3.Location = new System.Drawing.Point(586, 127);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(741, 174);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Editar el grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nuevo nombre del Grupo";
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditarGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarGrupo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditarGrupo.Location = new System.Drawing.Point(25, 97);
            this.btnEditarGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(225, 53);
            this.btnEditarGrupo.TabIndex = 25;
            this.btnEditarGrupo.Text = "Confirmar cambios";
            this.btnEditarGrupo.UseVisualStyleBackColor = false;
            this.btnEditarGrupo.Click += new System.EventHandler(this.btnEditarGrupo_Click_1);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(25, 61);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(678, 22);
            this.txtNuevoNombre.TabIndex = 27;
            // 
            // rbtnContactoCard
            // 
            this.rbtnContactoCard.AutoSize = true;
            this.rbtnContactoCard.Location = new System.Drawing.Point(37, 96);
            this.rbtnContactoCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnContactoCard.Name = "rbtnContactoCard";
            this.rbtnContactoCard.Size = new System.Drawing.Size(209, 20);
            this.rbtnContactoCard.TabIndex = 31;
            this.rbtnContactoCard.TabStop = true;
            this.rbtnContactoCard.Text = "Seleccionar contacto por Card";
            this.rbtnContactoCard.UseVisualStyleBackColor = true;
            this.rbtnContactoCard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnSacarContacto
            // 
            this.btnSacarContacto.Location = new System.Drawing.Point(57, 164);
            this.btnSacarContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSacarContacto.Name = "btnSacarContacto";
            this.btnSacarContacto.Size = new System.Drawing.Size(177, 58);
            this.btnSacarContacto.TabIndex = 30;
            this.btnSacarContacto.Text = "Eliminar Contacto del grupo";
            this.btnSacarContacto.UseVisualStyleBackColor = true;
            this.btnSacarContacto.Click += new System.EventHandler(this.btnSacarContacto_Click_1);
            // 
            // lstContactos
            // 
            this.lstContactos.FormattingEnabled = true;
            this.lstContactos.ItemHeight = 16;
            this.lstContactos.Location = new System.Drawing.Point(6, 23);
            this.lstContactos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstContactos.Name = "lstContactos";
            this.lstContactos.Size = new System.Drawing.Size(405, 132);
            this.lstContactos.TabIndex = 27;
            // 
            // btnAñadirContacto
            // 
            this.btnAñadirContacto.Location = new System.Drawing.Point(124, 162);
            this.btnAñadirContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirContacto.Name = "btnAñadirContacto";
            this.btnAñadirContacto.Size = new System.Drawing.Size(177, 58);
            this.btnAñadirContacto.TabIndex = 28;
            this.btnAñadirContacto.Text = "Añadir contacto al grupo";
            this.btnAñadirContacto.UseVisualStyleBackColor = true;
            this.btnAñadirContacto.Click += new System.EventHandler(this.btnAñadirContacto_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lsbGrupos);
            this.groupBox2.Location = new System.Drawing.Point(36, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(519, 181);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Grupo para editar:";
            // 
            // lsbGrupos
            // 
            this.lsbGrupos.FormattingEnabled = true;
            this.lsbGrupos.ItemHeight = 16;
            this.lsbGrupos.Location = new System.Drawing.Point(17, 54);
            this.lsbGrupos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbGrupos.Name = "lsbGrupos";
            this.lsbGrupos.Size = new System.Drawing.Size(483, 116);
            this.lsbGrupos.TabIndex = 25;
            this.lsbGrupos.SelectedIndexChanged += new System.EventHandler(this.lsbGrupos_SelectedIndexChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblResultado.Location = new System.Drawing.Point(583, 59);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(744, 39);
            this.lblResultado.TabIndex = 37;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lsbContactosDeGrupo);
            this.groupBox1.Location = new System.Drawing.Point(36, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(519, 263);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // lsbContactosDeGrupo
            // 
            this.lsbContactosDeGrupo.FormattingEnabled = true;
            this.lsbContactosDeGrupo.ItemHeight = 16;
            this.lsbContactosDeGrupo.Location = new System.Drawing.Point(20, 16);
            this.lsbContactosDeGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbContactosDeGrupo.Name = "lsbContactosDeGrupo";
            this.lsbContactosDeGrupo.Size = new System.Drawing.Size(480, 212);
            this.lsbContactosDeGrupo.TabIndex = 0;
            // 
            // lblBTelefono
            // 
            this.lblBTelefono.AutoSize = true;
            this.lblBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBTelefono.Location = new System.Drawing.Point(581, 11);
            this.lblBTelefono.Name = "lblBTelefono";
            this.lblBTelefono.Size = new System.Drawing.Size(205, 29);
            this.lblBTelefono.TabIndex = 35;
            this.lblBTelefono.Text = "Editar un Grupo";
            // 
            // rbtnContactoLista
            // 
            this.rbtnContactoLista.AutoSize = true;
            this.rbtnContactoLista.Location = new System.Drawing.Point(37, 71);
            this.rbtnContactoLista.Name = "rbtnContactoLista";
            this.rbtnContactoLista.Size = new System.Drawing.Size(222, 20);
            this.rbtnContactoLista.TabIndex = 32;
            this.rbtnContactoLista.TabStop = true;
            this.rbtnContactoLista.Text = "Seleccionar contacto por la Lista";
            this.rbtnContactoLista.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.lstContactos);
            this.groupBox4.Controls.Add(this.btnAñadirContacto);
            this.groupBox4.Location = new System.Drawing.Point(910, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 227);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Añadir contactos";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.rbtnContactoCard);
            this.groupBox5.Controls.Add(this.rbtnContactoLista);
            this.groupBox5.Controls.Add(this.btnSacarContacto);
            this.groupBox5.Location = new System.Drawing.Point(587, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 227);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar contactos";
            // 
            // frmEditarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 764);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBTelefono);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditarGrupo";
            this.Text = "frmEditarGrupo";
            this.Load += new System.EventHandler(this.frmEditarGrupo_Load_1);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnContactoCard;
        private System.Windows.Forms.Button btnSacarContacto;
        private System.Windows.Forms.ListBox lstContactos;
        private System.Windows.Forms.Button btnAñadirContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditarGrupo;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbGrupos;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbContactosDeGrupo;
        private System.Windows.Forms.Label lblBTelefono;
        private System.Windows.Forms.RadioButton rbtnContactoLista;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}