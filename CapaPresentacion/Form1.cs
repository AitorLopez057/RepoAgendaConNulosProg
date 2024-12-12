using System;
using System.Windows.Forms;
using GestionAgenda;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Gestion gestion = Program.GlobalConfig.Gestion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = gestion.ContactosOrdenados();
        }

        private void Contactos_Click(object sender, EventArgs e)
        {

        }
    }
}