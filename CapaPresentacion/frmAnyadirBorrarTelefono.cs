using Entidades;
using GestionAgenda;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

            gestion = Program.gestion; 

            if (gestion == null)
            {
                MessageBox.Show("La inicialización de la aplicación ha fallado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            cboContactos.Items.AddRange(gestion.ContactosOrdenados().ToArray());
        }

        private void frmAnyadirBorrarTelefono_Load(object sender, EventArgs e)
        {
            
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
            }
            else
            {
                lblResultado.Text = $"Eliminación de teléfono {telefonoSeleccionado.Numero} del contacto {contactoSeleccionado.Nombre} abortado correctamente.";
            }
<<<<<<< HEAD
            cboTlfonsDeContacto.Items.Clear();
            cboTlfonsDeContacto.Items.AddRange(gestion.TelefonosDeUnContacto(contactoSeleccionado.IdContacto).ToArray());

=======
            ActualizarCBOsDeTelefonos();
>>>>>>> 74cdb057857c79e162037fb64e8607481ab77f61
        }

        private void btnAnyadirTelefono_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (string.IsNullOrEmpty(txtTelefono.Text) || txtTelefono.Text.Length < 3)
=======
            if (contactoSeleccionado == null)
            {
                lblResultado.Text = "Debes de seleccionar un contacto";
                return;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
>>>>>>> 74cdb057857c79e162037fb64e8607481ab77f61
            {
                lblResultado.Text = "Debes de introducir un número de teléfono de al menos 3 dígitos.";
                return;
            }
            

            int resultado;
            if (!int.TryParse(txtTelefono.Text, out resultado))
            {
                lblResultado.Text = "El número de teléfono debe de ser un valor numérico.";
                return;
            }
            if(txtDescripcion.Text == "")
            {

<<<<<<< HEAD
                DialogResult dr = MessageBox.Show($"Vas a añadir un teléfono sin descripción. Realmente deseas hacerlo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    lblResultado.Text = $"Creación de teléfono {txtTelefono.Text} del contacto {contactoSeleccionado.Nombre} abortado correctamente.";
                    return;
                }
            }
            Telefonos telefonoNuevo = new Telefonos(txtTelefono.Text, txtDescripcion.Text);
            gestion.AnyadirTelefonoContacto(contactoSeleccionado.IdContacto, telefonoNuevo);
            lblResultado.Text = $"Teléfono {telefonoNuevo.Numero} añadido correctamente al contacto {contactoSeleccionado.Nombre}.";
            txtTelefono.Text = "";
            txtDescripcion.Text = "";

            cboTlfonsDeContacto.Items.Clear();
            cboTlfonsDeContacto.Items.AddRange(gestion.TelefonosDeUnContacto(contactoSeleccionado.IdContacto).ToArray());

            cboTelefonos.Items.Clear();
            cboTelefonos.Items.AddRange(gestion.TelefonosDeUnContacto(contactoSeleccionado.IdContacto).ToArray());
            
=======
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
            ActualizarCBOsDeTelefonos();
>>>>>>> 74cdb057857c79e162037fb64e8607481ab77f61
        }
        private void cboContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactoSeleccionado = cboContactos.SelectedItem as Contactos;

            //Mostrar información del contacto seleccionado
            lblNombre.Text = contactoSeleccionado.Nombre;
            lblEmail.Text = contactoSeleccionado.Email ?? "---";
            lblGrupo.Text = contactoSeleccionado.Grupos?.NombreGrupo ?? "---";

            ActualizarCBOsDeTelefonos();

            if (cboTlfonsDeContacto.Items.Count == 0)
            {
                cboTlfonsDeContacto.Items.Add("No hay teléfonos");
            }
            cboTlfonsDeContacto.SelectedIndex = 0; //ver primer telefono 
        }
        private void ActualizarCBOsDeTelefonos()
        {
            cboTlfonsDeContacto.Items.Clear();
            cboTlfonsDeContacto.Items.AddRange(contactoSeleccionado.Telefonos.ToArray());
            cboTelefonos.Items.Clear();
            cboTelefonos.Items.AddRange(contactoSeleccionado.Telefonos.ToArray());
        }
        private void cboTelefonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            telefonoSeleccionado = cboTelefonos.SelectedItem as Telefonos;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
