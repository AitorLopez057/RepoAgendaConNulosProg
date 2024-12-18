using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionAgenda;
¡namespace CapaPresentacion
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
            dgvContactos.DataSource = gestion.ContactosOrdenados();
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
    }
}