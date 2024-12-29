using GestionAgenda;
using System;
using System.Linq;
using System.Windows.Forms;
using Entidades;

namespace CapaPresentacion
{
    public partial class frmEliminarContacto : Form
    {
        Gestion gestion;

        public frmEliminarContacto()
        {
            InitializeComponent();
            gestion = new Gestion();
        }

        private void btnBorrarContacto_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtEliminarContacto.Text)) lblResultado.Text = "Debes de introducir el nombre del Contacto que quieres borrar";
            else
            {
                Contactos contacto = gestion.ContactosOrdenados().SingleOrDefault(con => con.Nombre == txtEliminarContacto.Text);
                if (contacto == null) lblResultado.Text=$"El contacto {txtEliminarContacto.Text} no existe";
                else
                {
                    String resultado = gestion.BorrarContacto(contacto.IdContacto);
                    if (resultado != "") MessageBox.Show(resultado);

                }
            }         
        }
        
    }
}
