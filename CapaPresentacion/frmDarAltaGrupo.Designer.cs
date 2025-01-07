namespace CapaPresentacion
{
    partial class frmDarAltaGrupo
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
            this.txtAñadirGrupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAñadirGrupo = new System.Windows.Forms.Button();
            this.lblBTelefono = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAñadirGrupo
            // 
            this.txtAñadirGrupo.Location = new System.Drawing.Point(22, 65);
            this.txtAñadirGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAñadirGrupo.Name = "txtAñadirGrupo";
            this.txtAñadirGrupo.Size = new System.Drawing.Size(134, 20);
            this.txtAñadirGrupo.TabIndex = 24;
            this.txtAñadirGrupo.TextChanged += new System.EventHandler(this.txtAñadirGrupo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre del Grupo";
            // 
            // btnAñadirGrupo
            // 
            this.btnAñadirGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAñadirGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirGrupo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAñadirGrupo.Location = new System.Drawing.Point(22, 151);
            this.btnAñadirGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirGrupo.Name = "btnAñadirGrupo";
            this.btnAñadirGrupo.Size = new System.Drawing.Size(169, 43);
            this.btnAñadirGrupo.TabIndex = 22;
            this.btnAñadirGrupo.Text = "Crear el grupo";
            this.btnAñadirGrupo.UseVisualStyleBackColor = false;
            this.btnAñadirGrupo.Click += new System.EventHandler(this.btnAñadirGrupo_Click);
            // 
            // lblBTelefono
            // 
            this.lblBTelefono.AutoSize = true;
            this.lblBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBTelefono.Location = new System.Drawing.Point(318, 22);
            this.lblBTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBTelefono.Name = "lblBTelefono";
            this.lblBTelefono.Size = new System.Drawing.Size(161, 25);
            this.lblBTelefono.TabIndex = 21;
            this.lblBTelefono.Text = "Crear un Grupo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(299, 370);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 335);
            this.panel1.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblResultado.Location = new System.Drawing.Point(319, 61);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(456, 32);
            this.lblResultado.TabIndex = 27;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAñadirGrupo);
            this.groupBox2.Controls.Add(this.txtAñadirGrupo);
            this.groupBox2.Location = new System.Drawing.Point(322, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(453, 216);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // frmDarAltaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBTelefono);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDarAltaGrupo";
            this.Text = "frmDarAltaGrupo";
            this.Load += new System.EventHandler(this.frmDarAltaGrupo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAñadirGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAñadirGrupo;
        private System.Windows.Forms.Label lblBTelefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}