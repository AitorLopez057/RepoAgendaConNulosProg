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
        Contactos contactoSeleccionado;
        int? idContacto;

        public frmEliminarContacto(int? id = null)
        {
            InitializeComponent();

            gestion = Program.gestion;
            if (id != null) idContacto = id;
            if (gestion == null)
            {
                MessageBox.Show("La inicialización de la aplicación ha fallado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            contactoSeleccionado = new Contactos();
        }

        private void btnBorrarContacto_Click(object sender, EventArgs e)

        {
            if (contactoSeleccionado.IdContacto != 0 || idContacto != null)
            {
                String nombre;
                if (idContacto != null) nombre = gestion.ContactoPorId(idContacto.Value).Nombre;
                else nombre = contactoSeleccionado.Nombre;
                DialogResult dr = MessageBox.Show($"Estás seguro de que quieres borrar el Contacto {contactoSeleccionado.Nombre}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    String resultado;
                    if (idContacto != null)
                    {
                        resultado = gestion.BorrarContacto(idContacto.Value);
                    }
                    resultado = gestion.BorrarContacto(contactoSeleccionado.IdContacto);
                    if (resultado != "") lblResultado.Text = resultado;
                    cboTodosContactos.Items.Clear();
                    cboTodosContactos.Text = "";
                    cboTodosContactos.Items.AddRange(gestion.ContactosOrdenados().ToArray());
                }
            }
            else
            {
                lblResultado.Text = "Debes de seleccionar un contacto en la lista.";
            }
        }

        private void frmEliminarContacto_Load(object sender, EventArgs e)
        {
            cboTodosContactos.Items.AddRange(gestion.ContactosOrdenados().ToArray());
            if (idContacto != null)
            {
                btnBorrarContacto_Click(null, null);

            }

        }

        private void cboTodosContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactoSeleccionado = cboTodosContactos.SelectedItem as Contactos;
        }
    }
}
