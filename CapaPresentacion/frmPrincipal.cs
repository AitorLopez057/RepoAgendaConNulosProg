using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionAgenda;
using Entidades;
using System.Linq;
using System.Diagnostics.Contracts;
using System.Runtime.Remoting.Channels;
namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        Gestion gestion = Program.gestion;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTodosContactos_Click(object sender, EventArgs e)
        {
            List<Contactos> contactos = new List<Contactos>();
            contactos = gestion.ContactosOrdenados();
            dgvContactos.DataSource = (from con in contactos
                                       select new
                                       {
                                           IdContacto = con.IdContacto,
                                           Nombre = con.Nombre,
                                           Email = con.Email ?? "---",
                                           NombreGrupo = con.Grupos?.NombreGrupo ?? "---",
                                           Telefonos = con.toStringTelefonos()
                                       }).ToList();
            lblMensaje.Text = "Todos los contactos con su nombre de grupo, cantidad de teléfonos y teléfonos";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmEliminarContacto frmBorrar = new frmEliminarContacto();
            frmBorrar.ShowDialog();
        }

        private void btnAñadirTelefonoContacto_Click(object sender, EventArgs e)
        {
            frmAnyadirBorrarTelefono frmAñadirTelefono = new frmAnyadirBorrarTelefono();
            frmAñadirTelefono.ShowDialog();
        }

        private void btnTelefonosContacto_Click(object sender, EventArgs e)
        {
            String idStr = txtIdContacto.Text;
            int id = 0;
            try
            {
                id = int.Parse(idStr);
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Debes introducir un número";
                dgvContactos.DataSource = "";
                return;
            }
            Contactos contacto = gestion.ContactoPorId(id);
            if (contacto == null)
            {
                lblMensaje.Text = $"No hay ningun contacto con el id: '{id}'";
                dgvContactos.DataSource = "";
            }
            else
            {
                var telefonos = gestion.TelefonosDeUnContacto(id);
                dgvContactos.DataSource = (from tel in telefonos
                                           select new
                                           {
                                               Número = tel.Numero,
                                               Descripción = tel.Descripcion ?? "---"
                                           }).ToList();

                if (contacto.Grupos != null)
                {
                    lblMensaje.Text = $"Telefonos de contacto: '{contacto.Nombre}' del Grupo '{contacto.Grupos}'";
                }
                else
                {
                    lblMensaje.Text = $"Telefonos de contacto: '{contacto.Nombre}', no pertenece a ningún grupo";
                }
            }

        }

        private void btnContactosTelefono_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumeroTelefono.Text))
            {
                lblMensaje.Text = "Inserte un teléfono";
                dgvContactos.DataSource = "";
            }
            else
            {
                String msg = "";
                List<Contactos> contactos = gestion.ContactosDeTelefono(txtNumeroTelefono.Text, out msg);
                if (contactos.Count == 0)
                {
                    lblMensaje.Text = $"No hay contactos del teléfono {txtNumeroTelefono.Text}";
                    dgvContactos.DataSource = "";
                }
                else
                {
                    dgvContactos.DataSource = (from con in contactos
                                               select new
                                               {
                                                   Nombre = con.Nombre,
                                                   CantTelefonos = con.Telefonos.Count(),
                                                   NombreGrupo = con.Grupos

                                               }).ToList();
                    lblMensaje.Text = $"Contactos del teléfono {txtNumeroTelefono.Text}";
                }

            }
        }

        private void btnDarDeAltaUnGrupo_Click_1(object sender, EventArgs e)
        {
            frmDarAltaGrupo frmDarAltaGrupo = new frmDarAltaGrupo();
            frmDarAltaGrupo.ShowDialog();
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            frmEliminarGrupo frmEliminarGrupo = new frmEliminarGrupo();
            frmEliminarGrupo.ShowDialog();
        }

        private void btnDarAltaContacto_Click(object sender, EventArgs e)
        {
            frmDarAltaContacto frmDarAltaContacto = new frmDarAltaContacto();
            frmDarAltaContacto.ShowDialog();
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            frmEliminarContacto frmEliminarContacto = new frmEliminarContacto();
            frmEliminarContacto.ShowDialog();
        }

        private void btnAnyadirTelefonoAContacto_Click(object sender, EventArgs e)
        {
            frmAnyadirBorrarTelefono frmAnñadirTelefono = new frmAnyadirBorrarTelefono();
            frmAnñadirTelefono.ShowDialog();
        }
        

        private void dgvContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    string id = dgvContactos.Rows[e.RowIndex].Cells["idContacto"].Value.ToString();
                    string name = dgvContactos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    string email = dgvContactos.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    string nGrupo = dgvContactos.Rows[e.RowIndex].Cells["NombreGrupo"].Value.ToString();
                    string telefonos = dgvContactos.Rows[e.RowIndex].Cells["Telefonos"].Value.ToString();


                    // Crea una instancia del formulario de detalle con los datos seleccionados
                    DetallesForm detalleForm = new DetallesForm();
                    detalleForm.SetDatos(id, name, email, nGrupo, telefonos);
                    detalleForm.Show();
                } catch(Exception ex)
                {
                    MessageBox.Show("No se puede ver la informacion en este momento");
                }
                // Obtén los datos de la fila seleccionada
                
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}