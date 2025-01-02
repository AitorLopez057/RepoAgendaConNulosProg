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
        Contactos contactoSeleccionado;
        Telefonos telefonoSeleccionado;
        public frmAnyadirBorrarTelefono()
        {
            InitializeComponent();
            gestion = new Gestion();
        }

        private void frmAnyadirBorrarTelefono_Load(object sender, EventArgs e)
        {
            cboContactos.Items.AddRange(gestion.ContactosOrdenados().ToArray());
        }

        private void btnBorrarTelefono_Click(object sender, EventArgs e)
        {
            if (contactoSeleccionado == null)
            {
                lblResultado.Text = "Debes de seleccionar un contacto";
                return;
            }
            if (telefonoSeleccionado == null)
            {
                lblResultado.Text = "Debes de seleccionar un teléfono";
                return;
            }

            DialogResult dr = MessageBox.Show($"Estás seguro de que quieres borrar el Teléfono {telefonoSeleccionado.Numero} del contacto {contactoSeleccionado.Nombre}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                gestion.BorrarTelefono(contactoSeleccionado.IdContacto, telefonoSeleccionado.Numero);
                lblResultado.Text = $"El teléfono {telefonoSeleccionado.Numero} del contacto {contactoSeleccionado.Nombre} ha sido eliminado correctamente.";
                cboTelefonos.Items.Clear();
                cboTelefonos.Items.AddRange(gestion.TelefonosDeUnContacto(contactoSeleccionado.IdContacto).ToArray());
                cboTelefonos.Text = "";
            }
            else
            {
                lblResultado.Text = $"Eliminación de teléfono {telefonoSeleccionado.Numero} del contacto {contactoSeleccionado.Nombre} abortado correctamente.";
            }
        }

        private void btnAnyadirTelefono_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                lblResultado.Text = "Debes de introducir un número de teléfono.";
                return;
            }

            int resultado;
            if (!int.TryParse(txtTelefono.Text, out resultado))
            {
                lblResultado.Text = "El número de teléfono debe de ser un valor numérico.";
                return;
            }

            DialogResult dr = MessageBox.Show($"Vas a añadir un teléfono sin descripción. Realmente deseas hacerlo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Telefonos telefonoNuevo = new Telefonos(txtTelefono.Text, txtDescripcion.Text);
                gestion.AnyadirTelefonoContacto(contactoSeleccionado.IdContacto, telefonoNuevo);
                lblResultado.Text = $"Teléfono {telefonoNuevo.Numero} añadido correctamente al contacto {contactoSeleccionado.Nombre}.";
                txtTelefono.Text = "";
                txtDescripcion.Text = "";
            }
            else
            {
                lblResultado.Text = $"Creación de teléfono {txtTelefono.Text} del contacto {contactoSeleccionado.Nombre} abortado correctamente.";
                
            }
        }
        private void cboContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTelefonos.Items.Clear();
            contactoSeleccionado = cboContactos.SelectedItem as Contactos;
            cboTelefonos.Items.AddRange(gestion.TelefonosDeUnContacto(contactoSeleccionado.IdContacto).ToArray());
        }

        private void cboTelefonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            telefonoSeleccionado = cboTelefonos.SelectedItem as Telefonos;
        }
    }
}
