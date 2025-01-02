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
            gestion = Program.gestion;

            if (gestion == null)
            {
                MessageBox.Show("La inicialización de la aplicación ha fallado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnEliminarGrupo_Click_1(object sender, EventArgs e)
        {
                if (grupoSeleccionado != null)
                {
                    DialogResult dr = MessageBox.Show($"Estás seguro de que quieres borrar el Grupo {grupoSeleccionado.NombreGrupo}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        string resultado = gestion.BorrarGrupo(grupoSeleccionado);
                        lblResultado.Text = resultado;
                        cboTodosGrupos.Items.Clear();
                        cboTodosGrupos.Text = "";
                        cboTodosGrupos.Items.AddRange(gestion.GruposOrdenados().ToArray());
                    }

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
