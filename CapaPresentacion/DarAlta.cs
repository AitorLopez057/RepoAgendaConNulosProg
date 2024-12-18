using Entidades;
using GestionAgenda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class DarAlta : Form
    {
        List<Telefonos> telefonos;
        Gestion gestion;
        public DarAlta()
        {
            InitializeComponent();
            telefonos = new List<Telefonos>();
            gestion = new Gestion();
            
        }

        private void btnAñadirContacto_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirTelefono_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirGrupo_Click(object sender, EventArgs e)
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
