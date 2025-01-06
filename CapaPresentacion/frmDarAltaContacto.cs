﻿using Entidades;
using GestionAgenda;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDarAltaContacto : Form
    {
        List<Telefonos> telefonos;
        Gestion gestion;
        public frmDarAltaContacto()
        {
            InitializeComponent();
            telefonos = new List<Telefonos>();
            gestion = Program.gestion;
            
            if (gestion == null)
            {
                MessageBox.Show("La inicialización de la aplicación ha fallado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();  
            }
            cboGrupo.Items.AddRange(gestion.GruposOrdenados().ToArray());
        }

        private void btnAñadirContacto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreContacto.Text;
            if (String.IsNullOrWhiteSpace(nombre))
            {
                lblResultado.Text = "El nombre del contacto no puede quedar vacio";
                return;
            }
            Grupos grupoAux = null;
            string error = "";
            Contactos contactoAux = null;
            try
            {
                if (cboGrupo.SelectedIndex == -1)
                {
                    lblResultado.Text = "Selecciona un grupo";
                    //contactoAux = new Contactos(nombre, null, -1);
                    //contactoAux.Telefonos = telefonos;
                    //error = gestion.AnyadirContacto(contactoAux);

                }else{
                    grupoAux = (Grupos)cboGrupo.SelectedItem;
                    contactoAux = new Contactos(nombre, null, grupoAux.IdGrupo);
                    contactoAux.Telefonos = telefonos;
                    if (telefonos.Count == 0)
                    {
                        DialogResult dr = MessageBox.Show($"Estás seguro de que quieres crear un contacto sin teléfonos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            error = gestion.AnyadirContacto(contactoAux);
                        }
                    }
                    else
                    {
                        error = gestion.AnyadirContacto(contactoAux);
                    }
                    
                }
                
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            
            if (error != "")
            {
                MessageBox.Show (error);
                return;
            }
            else
            {
                lblResultado.Text = $"El contacto con nombre {contactoAux.Nombre} se creado correctamente.";

                //Actualizar el cboTelefonos 
                ActualizarTelefonos();
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

            ActualizarTelefonos();
            

        }
        // Función para actualizar el cboTelefonos
        private void ActualizarTelefonos()
        {
            cboTelefonos.Items.Clear();
            if (telefonos != null && telefonos.Count > 0)
            {
                foreach (var telefono in telefonos)
                {
                    cboTelefonos.Items.Add(telefono);
                }
            }
            else
            {
                cboTelefonos.Items.Add("No hay teléfonos añadidos.");
            }
           
        }
        private void cboTelefonos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDarAltaContacto_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboTelefonos.SelectedIndex==-1) {
                MessageBox.Show("Debes seleccionar un teléfono");
                return;
            }
            else
            {
                try
                {
                    telefonos.Remove((Telefonos) cboTelefonos.SelectedItem);
                    ActualizarTelefonos();
                }
                catch 
                {
                    MessageBox.Show("No se ha podido eliminar el telefono");
                }
                
            }
        }
    }
}
