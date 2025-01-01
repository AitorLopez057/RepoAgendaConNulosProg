using Entidades;
using GestionAgenda;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAnyadirBorrarTelefono : Form
    {
        Gestion gestion;
        public frmAnyadirBorrarTelefono()
        {
            InitializeComponent();
            gestion = new Gestion();
        }

        private void btnBorrarTelefono_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnyadirTelefono_Click(object sender, EventArgs e)
        {

        }
    }
}
