using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionAgenda;
using Entidades;
using System.Linq;
using System.Diagnostics.Contracts;
using System.Runtime.Remoting.Channels;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        Gestion gestion = Program.gestion;

        private List<Contactos> contactosGeneral;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTodosContactos_Click(object sender, EventArgs e)
        {
            contactosGeneral = gestion.ContactosOrdenados();
            CrearCards(contactosGeneral);
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
            panel1.Controls.Clear();
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
                //CrearCards(gestion.TelefonosDeUnContacto(id)
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
            panel1.Controls.Clear();
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
                    contactosGeneral = contactos;
                    CrearCards(contactosGeneral);
                    dgvContactos.DataSource = (from con in contactos
                                               select new
                                               {
                                                   Nombre = con.Nombre,
                                                   Telefonos = con.Telefonos.Count(),
                                                   NombreGrupo = con.Grupos?.NombreGrupo ?? "---"

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
            string id;
            string name;
            string email;
            string nGrupo;
            string telefonos;
            if (e.RowIndex >= 0)
            {
                try
                {
                    id = dgvContactos.Rows[e.RowIndex].Cells["idContacto"].Value.ToString();
                    int idContacto = Convert.ToInt32(id);
                    FocusCard(idContacto, contactosGeneral, true);

                }
                catch (Exception ex)
                {
                    id = "";
                }
                try
                {
                    name = dgvContactos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                }
                catch (Exception ex)
                {
                    name = "";
                }
                try
                {
                    email = dgvContactos.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                }
                catch (Exception ex)
                {
                    email = "";
                }
                try
                {
                    nGrupo = dgvContactos.Rows[e.RowIndex].Cells["NombreGrupo"].Value.ToString();

                }
                catch (Exception ex)
                {
                    nGrupo = "";
                }
                try
                {
                    telefonos = dgvContactos.Rows[e.RowIndex].Cells["Telefonos"].Value.ToString();

                }
                catch (Exception ex)
                {
                    telefonos = "";
                }

                

                // Crea una instancia del formulario de detalle con los datos seleccionados
                DetallesForm detalleForm = new DetallesForm();
                detalleForm.SetDatos(id, name, email, nGrupo, telefonos);
                detalleForm.Show();
                // Obtén los datos de la fila seleccionada

            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditarContacto frmEditarContacto = new frmEditarContacto();
            frmEditarContacto.ShowDialog();
        }

        //Controles dinámicos:
        private string mensjaViejo ;
        private void CrearCards(List<Contactos> contactos)
        {
            panel1.Controls.Clear();
            //List<Contactos> contactos = gestion.ContactosOrdenados();
            panel1.Controls.Clear();
            int x = panel1.AutoScrollPosition.X + 20;
            int y = panel1.AutoScrollPosition.Y + 30;
            for (int i = 0; i <= contactos.Count - 1; i++)
            {
                Contactos contacto = contactos[i];
                GroupBox contactbox = new GroupBox
                {
                    Name = "contact_" + contacto.IdContacto,
                    Tag = contacto.IdContacto,
                    Size = new Size(150, 200), // Ajusta el tamaño según sea necesario
                    Location = new Point(x, y),
                    BackColor = Color.White
                };
                x += contactbox.Width + 20;
                contactbox.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag, contactos, true);
                };
                contactbox.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)contactbox.Tag);
                };
                contactbox.MouseHover += (sender, e) =>
                {
                    mensjaViejo = lblMensaje.Text;
                    lblMensaje.Text = "Haz doble click para ver los detalles del contacto";
                };
                contactbox.MouseLeave += (sender, e) =>
                {
                    lblMensaje.Text = mensjaViejo;
                };

                PictureBox picturebox = new PictureBox
                {
                    Location = new Point(20, 10),
                    Tag = contacto.IdContacto,
                    BackgroundImage = Image.FromFile("usuario.png"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                };
                picturebox.Click += (sender, e) =>
                {
                    FocusCard((int)picturebox.Tag, contactos, true);
                };
                picturebox.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)picturebox.Tag);
                };

                Label Nombre = new Label
                {
                    Text = contacto.Nombre,
                    Tag = contacto.IdContacto,
                    Location = new Point(10, 70) // Posición relativa al interior del GroupBox
                };
                Nombre.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag, contactos, true);
                };
                Nombre.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)contactbox.Tag);
                };

                Label Gmail = new Label
                {
                    Text = contacto.Email ?? "---",
                    Tag = contacto.IdContacto,
                    Location = new Point(10, 100) // Posición relativa al interior del GroupBox
                };
                Gmail.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag, contactos, true);
                };
                Gmail.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)contactbox.Tag);
                };

                int yTelefono = 160;
                Label Grupo = null;
                if (contacto.Grupos != null)
                {
                    Grupo = new Label
                    {
                        Text = "Nombre grupo: " + contacto.Grupos.NombreGrupo ?? "---",
                        Tag = contacto.IdContacto,
                        Location = new Point(10, 130), // Posición relativa al interior del GroupBox
                        AutoSize = true
                    };
                    Grupo.Click += (sender, e) =>
                    {
                        FocusCard((int)contactbox.Tag, contactos, true);
                    };
                    Grupo.MouseDoubleClick += (sender, e) =>
                    {
                        Detalles((int)contactbox.Tag);
                    };
                }
                else
                {
                    yTelefono = 130;
                }


                Label Telefonos = new Label
                {
                    Text = "Número de \nteléfonos: " + contacto.Telefonos.Count,
                    Tag = contacto.IdContacto,
                    Location = new Point(10, yTelefono), // Posición relativa al interior del GroupBox
                    AutoSize = true
                };
                Telefonos.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag, contactosGeneral, true);
                };
                Telefonos.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)contactbox.Tag);
                };


                contactbox.Controls.Add(picturebox);
                contactbox.Controls.Add(Nombre);
                contactbox.Controls.Add(Gmail);
                if (contacto.Grupos != null) contactbox.Controls.Add(Grupo);
                contactbox.Controls.Add(Telefonos);

                panel1.Controls.Add(contactbox);
            }

        }

        private void FocusCard(int idSeleccionado, List<Contactos> contactos, Boolean? dgv = false)
        {
            GroupBox seleccionado = new GroupBox();
            // Resetea el color de todos los GroupBox
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is GroupBox && ctrl.Tag.ToString() != idSeleccionado.ToString())
                {
                    ctrl.BackColor = Color.White;
                }
                else if (ctrl.Tag.ToString() == idSeleccionado.ToString())
                {
                    seleccionado = (GroupBox)ctrl;
                }
            }

            // Cambia el color del GroupBox seleccionado
            seleccionado.BackColor = Color.LightBlue;
            Focus(); //stack over flow

            if (dgv == true)
            {
                dgvContactos.ClearSelection();
                int index = contactos.IndexOf(gestion.ContactoPorId(idSeleccionado));
                dgvContactos.Rows[index].Selected = true;
            }

        }

        private void Detalles(int idSeleccionado)
        {
            DetallesForm detalleForm = new DetallesForm();
            Contactos contactoclicado = gestion.ContactoPorId(idSeleccionado);
            detalleForm.SetDatos(contactoclicado.IdContacto.ToString(), contactoclicado.Nombre, contactoclicado.Email, contactoclicado.Grupos?.NombreGrupo, contactoclicado.toStringTelefonos());
            detalleForm.Show();
        }



        private void btnEditarGrupo_Click(object sender, EventArgs e)
        {
            frmEditarGrupo frmEditarGrupo = new frmEditarGrupo();
            frmEditarGrupo.ShowDialog();
        }

        private void dgvContactos_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count != 0)
            {
                string columnHeader = dgvContactos.Columns[0].HeaderText;
                if (columnHeader.Equals("IdContacto", StringComparison.OrdinalIgnoreCase))
                {
                    FocusCard((int)dgvContactos.SelectedRows[0].Cells[0].Value, contactosGeneral);
                }
                else if (columnHeader.Equals("Nombre", StringComparison.OrdinalIgnoreCase))
                {
                    String nombre = dgvContactos.SelectedRows[0].Cells[0].Value.ToString();
                    FocusCard(contactosGeneral.SingleOrDefault(con => con.Nombre == nombre).IdContacto, contactosGeneral);
                }

            }
        }
    }
}