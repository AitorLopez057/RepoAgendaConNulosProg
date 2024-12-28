namespace CapaPresentacion
{
    partial class frmEliminarGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarGrupo));
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtAñadirGrupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAñadirGrupo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBTelefono = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResultado.Location = new System.Drawing.Point(550, 67);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(562, 40);
            this.lblResultado.TabIndex = 32;
            // 
            // txtAñadirGrupo
            // 
            this.txtAñadirGrupo.Location = new System.Drawing.Point(728, 155);
            this.txtAñadirGrupo.Name = "txtAñadirGrupo";
            this.txtAñadirGrupo.Size = new System.Drawing.Size(177, 22);
            this.txtAñadirGrupo.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "NOMBRE GRUPO";
            // 
            // btnAñadirGrupo
            // 
            this.btnAñadirGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAñadirGrupo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAñadirGrupo.Location = new System.Drawing.Point(601, 275);
            this.btnAñadirGrupo.Name = "btnAñadirGrupo";
            this.btnAñadirGrupo.Size = new System.Drawing.Size(259, 53);
            this.btnAñadirGrupo.TabIndex = 28;
            this.btnAñadirGrupo.Text = "Eliminar grupo";
            this.btnAñadirGrupo.UseVisualStyleBackColor = false;
            this.btnAñadirGrupo.Click += new System.EventHandler(this.btnAñadirGrupo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 454);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 199);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblBTelefono
            // 
            this.lblBTelefono.AutoSize = true;
            this.lblBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBTelefono.Location = new System.Drawing.Point(548, 22);
            this.lblBTelefono.Name = "lblBTelefono";
            this.lblBTelefono.Size = new System.Drawing.Size(234, 29);
            this.lblBTelefono.TabIndex = 34;
            this.lblBTelefono.Text = "Eliminar un Grupo";
            // 
            // frmEliminarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 450);
            this.Controls.Add(this.lblBTelefono);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtAñadirGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAñadirGrupo);
            this.Name = "frmEliminarGrupo";
            this.Text = "frmEliminarGrupo";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtAñadirGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAñadirGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBTelefono;
    }
}