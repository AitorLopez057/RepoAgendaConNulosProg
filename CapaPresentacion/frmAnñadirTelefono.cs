using Entidades;
using GestionAgenda;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAnñadirTelefono : Form
    {
        Gestion gestion;
        public frmAnñadirTelefono()
        {
            InitializeComponent();
            gestion = new Gestion();
        }

        private void btnBorrarTelefono_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEliminarTelefonoContacto.Text)) lblResultado.Text = "Inserte un contacto";
            else
            {
                Contactos contacto = gestion.ContactosOrdenados().SingleOrDefault(con => con.Nombre == txtEliminarTelefonoContacto.Text);
                if (contacto == null) lblResultado.Text = "El contacto no existe";
                else
                {
                    String resultado = gestion.BorrarTelefono(contacto.IdContacto, txtEliminarTelefono.Text);
                    if (resultado != "") lblResultado.Text = resultado;

                }
            }
        }

        private void btnAnyadirTelefono_Click(object sender, EventArgs e)
        {

        }
    }
}
