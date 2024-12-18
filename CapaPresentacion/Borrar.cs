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
using Entidades;

namespace CapaPresentacion
{
    public partial class Borrar : Form
    {
        Gestion gestion;

        public Borrar()
        {
            InitializeComponent();
            gestion = new Gestion();
        }

        private void btnBorrarContacto_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtEliminarContacto.Text)) MessageBox.Show("Inserte un contacto");
            else
            {
                Contactos contacto = gestion.contactos().SingleOrDefault(con => con.Nombre == txtEliminarContacto.Text);
                if (contacto == null) MessageBox.Show("El contacto no existe");
                else
                {
                    String resultado = gestion.BorrarContacto(contacto.IdContacto);
                    if (resultado != "") MessageBox.Show(resultado);

                }
            }         
        }

        private void btnBorrarTelefono_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEliminarTelefonoContacto.Text)) lblResultado.Text = "Inserte un contacto";
            else
            {
                Contactos contacto = gestion.contactos().SingleOrDefault(con => con.Nombre == txtEliminarTelefonoContacto.Text);
                if (contacto == null) lblResultado.Text = "El contacto no existe";
                else
                {              
                    String resultado = gestion.BorrarTelefono(contacto.IdContacto, txtEliminarTelefono.Text);
                    if (resultado != "") lblResultado.Text = resultado;

                }
            }
        }
    }
}
