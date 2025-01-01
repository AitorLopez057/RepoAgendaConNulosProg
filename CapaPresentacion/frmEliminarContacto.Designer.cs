namespace CapaPresentacion
{
    partial class frmEliminarContacto
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnBorrarContacto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBTelefono = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTodosContactos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblResultado.Location = new System.Drawing.Point(542, 63);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(731, 46);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBorrarContacto
            // 
            this.btnBorrarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarContacto.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBorrarContacto.Location = new System.Drawing.Point(546, 324);
            this.btnBorrarContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarContacto.Name = "btnBorrarContacto";
            this.btnBorrarContacto.Size = new System.Drawing.Size(271, 65);
            this.btnBorrarContacto.TabIndex = 3;
            this.btnBorrarContacto.Text = "Eliminar Contacto";
            this.btnBorrarContacto.UseVisualStyleBackColor = false;
            this.btnBorrarContacto.Click += new System.EventHandler(this.btnBorrarContacto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 454);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // lblBTelefono
            // 
            this.lblBTelefono.AutoSize = true;
            this.lblBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBTelefono.Location = new System.Drawing.Point(541, 18);
            this.lblBTelefono.Name = "lblBTelefono";
            this.lblBTelefono.Size = new System.Drawing.Size(269, 29);
            this.lblBTelefono.TabIndex = 35;
            this.lblBTelefono.Text = "Eliminar un Contacto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Selecciona un Contacto a eliminar";
            // 
            // cboTodosContactos
            // 
            this.cboTodosContactos.FormattingEnabled = true;
            this.cboTodosContactos.Location = new System.Drawing.Point(546, 196);
            this.cboTodosContactos.Name = "cboTodosContactos";
            this.cboTodosContactos.Size = new System.Drawing.Size(201, 24);
            this.cboTodosContactos.TabIndex = 37;
            this.cboTodosContactos.SelectedIndexChanged += new System.EventHandler(this.cboTodosContactos_SelectedIndexChanged);
            // 
            // frmEliminarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 450);
            this.Controls.Add(this.cboTodosContactos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBTelefono);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBorrarContacto);
            this.Controls.Add(this.lblResultado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEliminarContacto";
            this.Text = "Borrar";
            this.Load += new System.EventHandler(this.frmEliminarContacto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnBorrarContacto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTodosContactos;
    }
}