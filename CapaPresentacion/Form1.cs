using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionAgenda;
using Entidades;
using System.Linq;
using System.Diagnostics.Contracts;
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

        private void btnContactosTelefono_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumeroTelefono.Text))
            {
                lblMensaje.Text = "Inserte un teléfono";
            }
            else 
            {
                String msg = "";
                List<Contactos> contactos = gestion.ContactosDeTelefono(txtNumeroTelefono.Text, out msg);
                if (contactos.Count == 0) lblMensaje.Text = "No hay contactos con ese teléfono";
                else
                {
                     dgvContactos.DataSource = (from con in contactos
                                                select new
                                                {
                                                    con.Nombre,
                                                    CantTelefonos = con.Telefonos == null ? 0 : con.Telefonos.Count(),
                                                    con.Grupos.NombreGrupo 
                                                }).ToList();
                    lblMensaje.Text = msg;
                }
            }
        }
    }
}