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
            string error = "";
            Contactos contactoAux = null;
            try
            {
                if (cboGrupo.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un grupo");
                    //contactoAux = new Contactos(nombre, null, -1);
                    //contactoAux.Telefonos = telefonos;
                    //error = gestion.AnyadirContacto(contactoAux);

                }
                else
                {
                    grupoAux = (Grupos)cboGrupo.Items[cboGrupo.SelectedIndex];
                    contactoAux = new Contactos(nombre, null, grupoAux.IdGrupo);
                    contactoAux.Telefonos = telefonos;
                    error = gestion.AnyadirContacto(contactoAux);
                }
                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        private void btnAñadirGrupo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAñadirGrupo.Text))
            {
                lblResultado.Text = "Debes introducir un nombre de grupo.";
            }
            else
            {
                String resultado = gestion.anyadirGrupos(txtAñadirGrupo.Text);
                if (resultado != "")
                {
                    lblResultado.Text = resultado;
                }
                else
                {
                    lblResultado.Text = $"El grupo con nombre {txtAñadirGrupo.Text} ha sido añadido correctamente.";
                }
            }

        }
    }
}
