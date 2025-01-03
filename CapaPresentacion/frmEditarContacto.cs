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
    public partial class frmEditarContacto : Form
    {
        Gestion gestion;
        public frmEditarContacto()
        {
            InitializeComponent();
            gestion = Program.gestion;

            if (gestion == null)
            {
                MessageBox.Show("La inicialización de la aplicación ha fallado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            cboGrupo.Items.AddRange(gestion.GruposOrdenados().ToArray());
            cboContactos.Items.AddRange(gestion.ContactosOrdenados().ToArray());
        }
        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboContactos.SelectedItem == null)
                {

                    lblResultado.Text = "Debes seleccionar un contacto para editar.";
                    return;
                }

                var contactoSeleccionado = (Contactos)cboContactos.SelectedItem;
                int idContacto = contactoSeleccionado.IdContacto;

           
                string nuevoNombre = txtNombreNuevo.Text;
                if (nuevoNombre == "")
                {
                    nuevoNombre = contactoSeleccionado.Nombre;
                }
                string nuevoEmail = txtEmailNuevo.Text;
                if (nuevoEmail == "")
                {
                    nuevoEmail = contactoSeleccionado.Email;
                }

                var grupoSeleccionado = (Grupos)cboGrupo.SelectedItem;
                int? idNuevoGrupo = contactoSeleccionado.IdGrupo;

                if (grupoSeleccionado != null)
                {
                    idNuevoGrupo = grupoSeleccionado.IdGrupo;
                }

                // Crear contacto a editar
                var contacto = new Contactos{IdContacto = idContacto,Nombre = nuevoNombre,Email = nuevoEmail,IdGrupo = idNuevoGrupo};

      
                string resultado = gestion.EditarContacto(contacto);
                lblResultado.Text = resultado;

                // limpiar campos
                cboContactos.Items.Clear();
                cboContactos.Items.AddRange(gestion.ContactosOrdenados().ToArray());
                txtNombreNuevo.Clear();
                txtEmailNuevo.Clear();
                cboGrupo.SelectedIndex = -1;
            }
            catch { }
        }
        private void lblBTelefono_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
