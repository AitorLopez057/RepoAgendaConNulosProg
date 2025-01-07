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
using System.Diagnostics.Contracts;

namespace CapaPresentacion
{
    public partial class frmEditarGrupo : Form
    {
        Gestion gestion;
        private Contactos contSeleccionado;
        public frmEditarGrupo()
        {
            InitializeComponent();
            gestion = Program.gestion;

            if (gestion == null)
            {
                MessageBox.Show("La inicialización de la aplicación ha fallado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
      
        private void RecargarListas()
        {
            CrearContactos();
            List<Contactos> contactos = gestion.ContactosOrdenados()
                    .Where(con => con.Grupos != null && con.Grupos.IdGrupo == (lsbGrupos.SelectedItem as Grupos).IdGrupo)
                    .ToList();
            lsbContactos.Items.Clear();
            lsbContactos.Items.AddRange(contactos.ToArray());
            listBox1.Items.Clear();
            listBox1.Items.AddRange(gestion.ContactosOrdenados().Where(con => con.Grupos == null || con.Grupos.IdGrupo != ((Grupos)lsbGrupos.SelectedItem).IdGrupo).ToArray());
        }

        private void CrearContactos()
        {
            panel1.Controls.Clear();
            List<Contactos> contactos = gestion.ContactosOrdenados()
                    .Where(con => con.Grupos != null && con.Grupos.IdGrupo == (lsbGrupos.SelectedItem as Grupos).IdGrupo)
                    .ToList();
            panel1.Controls.Clear();
            int x = panel1.AutoScrollPosition.X;
            int y = panel1.AutoScrollPosition.Y + 30;
            for (int i = 0; i <= contactos.Count - 1; i++)
            {
                Contactos contacto = contactos[i];
                GroupBox contactbox = new GroupBox
                {
                    Name = "contact_" + contacto.IdContacto,
                    Tag = contacto.IdContacto,
                    Size = new Size(150, 130), // Ajusta el tamaño según sea necesario
                    Location = new Point(x, y),
                    BackColor = Color.White
                };
                x += contactbox.Width + 20;
                contactbox.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag);
                };

                Label Nombre = new Label
                {
                    Text = contacto.Nombre,
                    Tag = contacto.IdContacto,
                    Location = new Point(10, 20) // Posición relativa al interior del GroupBox
                };
                Nombre.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag);
                };

                Label Gmail = new Label
                {
                    Text = contacto.Email,
                    Tag = contacto.IdContacto,
                    Location = new Point(10, 50) // Posición relativa al interior del GroupBox
                };
                Gmail.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag);
                };

                Label Telefonos = new Label
                {
                    Text = "Número de \nteléfonos: " + contacto.Telefonos.Count,
                    Tag = contacto.IdContacto,
                    Location = new Point(10, 80), // Posición relativa al interior del GroupBox
                    AutoSize = true
                };
                Telefonos.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag);
                };


                contactbox.Controls.Add(Nombre);
                contactbox.Controls.Add(Gmail);
                contactbox.Controls.Add(Telefonos);

                panel1.Controls.Add(contactbox);
            }

        }

        private void FocusCard(int idSeleccionado)
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
            contSeleccionado = gestion.ContactoPorId(idSeleccionado);
            Focus();
        }

        private Contactos getContactoSelec()
        {
            if (radioButton1.Checked)
            {
                return contSeleccionado;
            }
            return lsbContactos.SelectedItem as Contactos;
        }

        //
        private void btnBorrarContacto_Click_1(object sender, EventArgs e)
        {
            Contactos contacto = getContactoSelec();
            if (contacto != null)
            {
                frmEliminarContacto frmEliminar = new frmEliminarContacto(contacto.IdContacto);
                frmEliminar.ShowDialog();
            }
            else
            {
                lblResultado.Text = "Debes de seleccionar un contacto.";
            }
        }
        //
        private void btnSacarContacto_Click_1(object sender, EventArgs e)
        {
            Contactos contacto = getContactoSelec();
            if (contacto != null)
            {
                gestion.SacarContactoDeGrupo((lsbGrupos.SelectedItem as Grupos).IdGrupo, contacto.IdContacto);
                RecargarListas();
            }
            else
            {
                lblResultado.Text = "Debes de seleccionar un contacto.";
            }
        }
        //
        private void btnAñadirContacto_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (lsbGrupos.SelectedItem == null)
                {
                    lblResultado.Text = "Debes de seleccionar un grupo.";
                    return;
                }
                Contactos contacto = (Contactos)listBox1.SelectedItem;
                gestion.AñadirContactoAGrupo((lsbGrupos.SelectedItem as Grupos).IdGrupo, contacto.IdContacto);

                RecargarListas();
            }
            else
            {
                lblResultado.Text = "Debes de seleccionar un contacto.";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //
        private void btnEditarGrupo_Click_1(object sender, EventArgs e)
        {
           if(lsbGrupos.SelectedIndex == -1)
            {
                lblResultado.Text = "Debes de seleccionar un grupo.";
                return;
            }
           
            String mensaje = gestion.EditarGrupo((lsbGrupos.SelectedItem as Grupos).IdGrupo, txtNuevoNombre.Text);
            if (mensaje == "")
            {
                lblResultado.Text = "Grupo editado correctamente.";
                lsbGrupos.Items.Clear();
                lsbGrupos.Items.AddRange(gestion.GruposOrdenados().ToArray());
                lsbContactos.Items.Clear();
                txtNuevoNombre.Text = "";
                listBox1.Items.AddRange(gestion.GruposOrdenados().ToArray());
                panel1.Controls.Clear();

            }

            else lblResultado.Text = mensaje;
        }
        //
       

        private void frmEditarGrupo_Load_1(object sender, EventArgs e)
        {
            lsbContactos.Items.Clear();
            lsbGrupos.Items.Clear();
            lsbGrupos.Items.AddRange(gestion.GruposOrdenados().ToArray());
            listBox1.Items.AddRange(gestion.ContactosOrdenados().ToArray());

            Grupos grupo = lsbGrupos.SelectedItem as Grupos;
           // lsbContactos.Items.AddRange(gestion.ContactosOrdenados().Where(cont =>cont.Grupos != null && cont.Grupos.IdGrupo== grupo.IdGrupo).ToArray());

        }

        private void lsbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Grupos gruposSelec = (Grupos)lsbGrupos.SelectedItem;
            if (gruposSelec != null)
            {
                txtNuevoNombre.Text = gruposSelec.NombreGrupo;
                if (gestion.ExisteGrupo(gruposSelec.IdGrupo))
                {
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(gestion.ContactosOrdenados().Where(con => con.Grupos == null || con.Grupos.IdGrupo != gruposSelec.IdGrupo).ToArray());

                    List<Contactos> contactos = gestion.ContactosOrdenados()
                    .Where(con => con.Grupos != null && con.Grupos.IdGrupo == (lsbGrupos.SelectedItem as Grupos).IdGrupo)
                    .ToList();

                    lsbContactos.Items.AddRange(contactos.ToArray());
                    if (contactos.Count == 0)
                    {
                        lblResultado.Text = "No hay contactos en el grupo seleccionado.";
                        lsbContactos.Items.Clear();
                    }
                    else
                    {
                        lsbContactos.Items.Clear();
                        lsbContactos.Items.AddRange(contactos.ToArray());
                        CrearContactos();
                        lblResultado.Text = "";
                    }
                }
                else
                {
                    lsbContactos.Items.Clear();
                    lblResultado.Text = "No existe el grupo seleccionado.";
                }
            }
        }
    }
}
