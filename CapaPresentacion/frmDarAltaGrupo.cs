using Entidades;
using GestionAgenda;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDarAltaGrupo : Form
    {
        List<Telefonos> telefonos;
        Gestion gestion;
        public frmDarAltaGrupo()
        {
            InitializeComponent();
            telefonos = new List<Telefonos>();
            gestion = Program.gestion;

            if (gestion == null)
            {
                MessageBox.Show("La inicialización de la aplicación ha fallado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();  
            }
        }

        private void btnAñadirGrupo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAñadirGrupo.Text))
            {
                lblResultado.Text = "Debes introducir un nombre de grupo.";
            }
            else
            {
                String resultado = gestion.anyadirGrupos(txtAñadirGrupo.Text);
                if (resultado != "")
                {
                    lblResultado.Text = resultado;
                }
                else
                {
                    lblResultado.Text = $"El grupo con nombre {txtAñadirGrupo.Text} ha sido añadido correctamente.";
                }
            }
        }
    }
}
