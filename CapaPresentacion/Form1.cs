using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionAgenda;
using Entidades;
using System.Linq;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Gestion gestion = Program.gestion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Contactos_Click(object sender, EventArgs e)
        {

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
                                           Email = con.Email?? "---",
                                           NombreGrupo = con.Grupos?.NombreGrupo ?? "---",
                                           Telefonos = con.toStringTelefonos()
                                       }).ToList();
            lblMensaje.Text = "Todos los contactos con su nombre de grupo, cantidad de teléfonos y primer teléfono";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar frmBorrar = new Borrar();
            frmBorrar.ShowDialog();
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            DarAlta frmDarAlta = new DarAlta();
            frmDarAlta.ShowDialog();
        }

        private void btnAñadirTelefonoContacto_Click(object sender, EventArgs e)
        {
            AñadirTelefono frmAñadirTelefono = new AñadirTelefono();
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
            catch(Exception ex)
            {
                lblMensaje.Text = "Debes introducir un número";
            }
            Contactos contacto = gestion.ContactoPorId(id);
            if( contacto == null )
            {
                lblMensaje.Text = $"No hay ningun contacto con el id: '{id}'";
            }
            dgvContactos.DataSource = (from tel in contacto.Telefonos
                                       select new
                                       {
                                           Telefono = tel.Numero,
                                           Descripcion = tel.Descripcion ?? "---"
                                       }).ToList();
            lblMensaje.Text = $"Telefonos de contacto: '{contacto.Nombre}' del Grupo ''";




        }
    }
}