using Entidades;
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
using System.Windows.Forms.VisualStyles;

namespace CapaPresentacion
{
    public partial class DarAlta : Form
    {
        List<Telefonos> telefonos;
        Gestion gestion;
        public DarAlta()
        {
            InitializeComponent();
            telefonos = new List<Telefonos>();
            gestion = new Gestion();
            cboGrupo.Items.AddRange(gestion.GruposOrdenados().ToArray());
        }

        private void btnAñadirContacto_Click(object sender, EventArgs e)
        {
            string nombre= txtNombreContacto.Text;
            if (String.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show($"El nombre del contacto no puede quedar vacio");
                return;
            }
            Grupos grupoAux = null;
            try
            {
                grupoAux = (Grupos)cboGrupo.Items[cboGrupo.SelectedIndex];
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            string error = gestion.AnyadirContacto(new Contactos(nombre,null, grupoAux.IdGrupo));
            if (error != "")
            {
                MessageBox.Show (error);
                return;
            }
            telefonos = new List<Telefonos>();
        }

        private void btnAñadirTelefono_Click(object sender, EventArgs e)
        {
            int aux;
            if (!int.TryParse(txtTelefono.Text, out aux))
            {
                MessageBox.Show($"'{txtTelefono.Text}' no es un valor numérico");
            }
            else
            {
                telefonos.Add(new Telefonos(txtTelefono.Text,txtDescripcionTelefono.Text));
                txtDescripcionTelefono.Text = "";
                txtTelefono.Text = "";
            }
        }
    }
}
