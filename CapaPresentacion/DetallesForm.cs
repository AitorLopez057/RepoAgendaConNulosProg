using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace CapaPresentacion
{
    public partial class DetallesForm : Form
    {
        public DetallesForm()
        {
            InitializeComponent();
        }
        private void DetallesForm_Load(object sender, EventArgs e)
        {

        }
        public void SetDatos(String id, String nombre, String email, String nombreGrupo, String telefonos) 
        {
            txtEmail.Text = email;
            txtID.Text = id;
            txtNombre.Text = nombre;
            txtNombreGrupo.Text = nombreGrupo;
            txtTelefonos.Text = telefonos;

        }

  
    }
}
