using Entidades;
using GestionAgenda;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmEliminarGrupo : Form
    {
        Gestion gestion;
        Grupos grupoSeleccionado;
        public frmEliminarGrupo()
        {
            InitializeComponent();
            gestion = new Gestion();
        }

        private void btnEliminarGrupo_Click_1(object sender, EventArgs e)
        {
            if(grupoSeleccionado != null)
            {
                string resultado = gestion.BorrarGrupo(grupoSeleccionado);
                lblResultado.Text = resultado;
                cboTodosGrupos.Items.Clear();
                cboTodosGrupos.Text = "";
                cboTodosGrupos.Items.AddRange(gestion.GruposOrdenados().ToArray());
            }
            else
            {
                lblResultado.Text = "Debes de seleccionar un grupo para borrar. ";
            }
            
        }

        private void frmEliminarGrupo_Load(object sender, EventArgs e)
        {
            cboTodosGrupos.Items.AddRange(gestion.GruposOrdenados().ToArray());

        }

        private void cboTodosGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            grupoSeleccionado = cboTodosGrupos.SelectedItem as Grupos;
        }
    }
}
