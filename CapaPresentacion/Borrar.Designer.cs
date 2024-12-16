namespace CapaPresentacion
{
    partial class Borrar
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
            this.lblBContacto = new System.Windows.Forms.Label();
            this.lblBTelefono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBContacto
            // 
            this.lblBContacto.AutoSize = true;
            this.lblBContacto.Location = new System.Drawing.Point(74, 70);
            this.lblBContacto.Name = "lblBContacto";
            this.lblBContacto.Size = new System.Drawing.Size(117, 16);
            this.lblBContacto.TabIndex = 0;
            this.lblBContacto.Text = "Borrar un Contacto";
            // 
            // lblBTelefono
            // 
            this.lblBTelefono.AutoSize = true;
            this.lblBTelefono.Location = new System.Drawing.Point(698, 70);
            this.lblBTelefono.Name = "lblBTelefono";
            this.lblBTelefono.Size = new System.Drawing.Size(118, 16);
            this.lblBTelefono.TabIndex = 1;
            this.lblBTelefono.Text = "Borrar un Telefono";
            // 
            // Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 608);
            this.Controls.Add(this.lblBTelefono);
            this.Controls.Add(this.lblBContacto);
            this.Name = "Borrar";
            this.Text = "Borrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBContacto;
        private System.Windows.Forms.Label lblBTelefono;
    }
}