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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSacarContacto = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBorrarContacto = new System.Windows.Forms.Button();
            this.btnAñadirContacto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditarGrupo = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbGrupos = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbContactos = new System.Windows.Forms.ListBox();
            this.lblBTelefono = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(27, 458);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 178);
            this.panel1.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.btnSacarContacto);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.btnBorrarContacto);
            this.groupBox3.Controls.Add(this.btnAñadirContacto);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnEditarGrupo);
            this.groupBox3.Controls.Add(this.txtNuevoNombre);
            this.groupBox3.Location = new System.Drawing.Point(440, 121);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(556, 317);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 225);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(169, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Seleccionar contacto por Card";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnSacarContacto
            // 
            this.btnSacarContacto.Location = new System.Drawing.Point(29, 154);
            this.btnSacarContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnSacarContacto.Name = "btnSacarContacto";
            this.btnSacarContacto.Size = new System.Drawing.Size(133, 47);
            this.btnSacarContacto.TabIndex = 30;
            this.btnSacarContacto.Text = "Sacar Contacto Seleccionado";
            this.btnSacarContacto.UseVisualStyleBackColor = true;
            this.btnSacarContacto.Click += new System.EventHandler(this.btnSacarContacto_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(376, 45);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 95);
            this.listBox1.TabIndex = 27;
            // 
            // btnBorrarContacto
            // 
            this.btnBorrarContacto.Location = new System.Drawing.Point(205, 45);
            this.btnBorrarContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarContacto.Name = "btnBorrarContacto";
            this.btnBorrarContacto.Size = new System.Drawing.Size(133, 47);
            this.btnBorrarContacto.TabIndex = 29;
            this.btnBorrarContacto.Text = "Borrar contacto Seleccionado";
            this.btnBorrarContacto.UseVisualStyleBackColor = true;
            this.btnBorrarContacto.Click += new System.EventHandler(this.btnBorrarContacto_Click_1);
            // 
            // btnAñadirContacto
            // 
            this.btnAñadirContacto.Location = new System.Drawing.Point(376, 154);
            this.btnAñadirContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirContacto.Name = "btnAñadirContacto";
            this.btnAñadirContacto.Size = new System.Drawing.Size(133, 47);
            this.btnAñadirContacto.TabIndex = 28;
            this.btnAñadirContacto.Text = "Añadir contacto";
            this.btnAñadirContacto.UseVisualStyleBackColor = true;
            this.btnAñadirContacto.Click += new System.EventHandler(this.btnAñadirContacto_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nuevo nombre del Grupo";
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditarGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarGrupo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditarGrupo.Location = new System.Drawing.Point(19, 258);
            this.btnEditarGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(169, 43);
            this.btnEditarGrupo.TabIndex = 25;
            this.btnEditarGrupo.Text = "Confirmar cambios";
            this.btnEditarGrupo.UseVisualStyleBackColor = false;
            this.btnEditarGrupo.Click += new System.EventHandler(this.btnEditarGrupo_Click_1);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(19, 74);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNuevoNombre.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lsbGrupos);
            this.groupBox2.Location = new System.Drawing.Point(27, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(389, 147);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Grupo para editar:";
            // 
            // lsbGrupos
            // 
            this.lsbGrupos.FormattingEnabled = true;
            this.lsbGrupos.Location = new System.Drawing.Point(13, 44);
            this.lsbGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.lsbGrupos.Name = "lsbGrupos";
            this.lsbGrupos.Size = new System.Drawing.Size(363, 95);
            this.lsbGrupos.TabIndex = 25;
            this.lsbGrupos.SelectedIndexChanged += new System.EventHandler(this.lsbGrupos_SelectedIndexChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblResultado.Location = new System.Drawing.Point(437, 48);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(558, 32);
            this.lblResultado.TabIndex = 37;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lsbContactos);
            this.groupBox1.Location = new System.Drawing.Point(27, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(389, 214);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // lsbContactos
            // 
            this.lsbContactos.FormattingEnabled = true;
            this.lsbContactos.Location = new System.Drawing.Point(15, 13);
            this.lsbContactos.Margin = new System.Windows.Forms.Padding(2);
            this.lsbContactos.Name = "lsbContactos";
            this.lsbContactos.Size = new System.Drawing.Size(361, 173);
            this.lsbContactos.TabIndex = 0;
            // 
            // lblBTelefono
            // 
            this.lblBTelefono.AutoSize = true;
            this.lblBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBTelefono.Location = new System.Drawing.Point(436, 9);
            this.lblBTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBTelefono.Name = "lblBTelefono";
            this.lblBTelefono.Size = new System.Drawing.Size(161, 25);
            this.lblBTelefono.TabIndex = 35;
            this.lblBTelefono.Text = "Crear un Grupo";
            // 
            // frmEditarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBTelefono);
            this.Name = "frmEditarGrupo";
            this.Text = "frmEditarGrupo";
            this.Load += new System.EventHandler(this.frmEditarGrupo_Load_1);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSacarContacto;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBorrarContacto;
        private System.Windows.Forms.Button btnAñadirContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditarGrupo;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbGrupos;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbContactos;
        private System.Windows.Forms.Label lblBTelefono;
    }
}