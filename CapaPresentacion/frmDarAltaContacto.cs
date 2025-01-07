using Entidades;
using GestionAgenda;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
                    error = "Selecciona un grupo";
                    //contactoAux = new Contactos(nombre, null, -1);
                    //contactoAux.Telefonos = telefonos;
                    //error = gestion.AnyadirContacto(contactoAux);

                }
                else
                {
                    grupoAux = (Grupos)cboGrupo.SelectedItem;
                    contactoAux = new Contactos(txtNombreContacto.Text, txtEmail.Text, grupoAux.IdGrupo); 

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (error != "")
            {
                lblResultado.Text=error;
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
                lblResultado.Text = $"'{txtTelefono.Text}' no es un valor numérico";
            }
            else if(txtTelefono.Text.Length <3)
            {
                lblResultado.Text = "El teléfono debe tener mínimo 3 dígitos.";
            }
            
            else
            {

                telefonos.Add(new Telefonos(txtTelefono.Text,txtDescripcionTelefono.Text));
                lblResultado.Text = $"Teléfono {txtTelefono.Text} añadido correctamente. Cuando se cree el contacto se crearán los teléfonos";
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
<<<<<<< HEAD

                    cboTelefonos.Items.Add($"{telefono.Numero}: {telefono.Descripcion}");
=======
                    cboTelefonos.Items.Add(telefono);
>>>>>>> 74cdb057857c79e162037fb64e8607481ab77f61
                }
            }
            else
            {
                cboTelefonos.Items.Add("No hay teléfonos añadidos.");
            }
           
        }
        private String mensajeviejo; //recoge el mensaje antes del hover para ponerlo al salir de hover

        private void label2_MouseHover(object sender, EventArgs e)
        {
            mensajeviejo = lblResultado.Text;
            lblResultado.Text = "info: El emial tiene que ser de la forma: < *@*.* >, sin espacios y con 5<numCaracteres<30";
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            lblResultado.Text = mensajeviejo;
        }

        private void txtEmail_MouseHover(object sender, EventArgs e)
        {
            mensajeviejo = lblResultado.Text;
            lblResultado.Text = "info: El email tiene que ser de la forma: < *@*.* >, sin espacios y con 5<numCaracteres<30";
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            lblResultado.Text = mensajeviejo;
        }

        private void Detalles(int idSeleccionado)
        {
            DetallesForm detalleForm = new DetallesForm();
            Contactos contactoclicado = gestion.ContactoPorId(idSeleccionado);
            detalleForm.SetDatos(contactoclicado.IdContacto.ToString(), contactoclicado.Nombre, contactoclicado.Email, contactoclicado.Grupos?.NombreGrupo, contactoclicado.toStringTelefonos());
            detalleForm.Show();
        }

        private String mensjaViejo;

        private void CrearCards()
        {

            List<Contactos> contactosExistentes;
            if (txtNombreContacto.Text == "")
            {
                contactosExistentes = gestion.ContactosOrdenados();
            }
            else
            {
                contactosExistentes = gestion.ContactosOrdenados().Where(con => con.Nombre.ToLower().StartsWith(txtNombreContacto.Text.ToString().ToLower())).ToList();

                if (!contactosExistentes.Any(con => con.Nombre.ToLower().Equals(txtNombreContacto.Text.ToLower()))) lblResultado.Text = "info: Nombre válido: no hay contactos con ese nombre";
                else lblResultado.Text = "info: Nombre NO valido: hay contactos con ese nombre";
            }

            Label Titulo = new Label
            {
                Tag = "Titulo",
                Location = new Point(panel1.AutoScrollPosition.X, panel1.AutoScrollPosition.Y),
                AutoSize = true
            };
            if (contactosExistentes.Count == 0)
            {
                Titulo.Text = "No hay contactos que empiezan como: " + txtNombreContacto.Text;
            }
            else if (!String.IsNullOrEmpty(txtNombreContacto.Text))
            {
                Titulo.Text = "Contactos que empiezan como: " + txtNombreContacto.Text;
            }
            else
            {
                Titulo.Text = "Todos los contactos";
            }

            panel1.Controls.Clear();
            int x = panel1.AutoScrollPosition.X + 20; // Eje X fijo
            int y = panel1.AutoScrollPosition.Y + 40; // Eje Y dinámico

            for (int i = 0; i < contactosExistentes.Count; i++)
            {
                Contactos contacto = contactosExistentes[i];
                GroupBox contactbox = new GroupBox
                {
                    Name = "contact_" + contacto.IdContacto,
                    Tag = contacto.IdContacto,
                    Size = new Size(150, 200), // Ajusta el tamaño según sea necesario
                    Location = new Point(x, y), // Posición relativa
                    BackColor = Color.White
                };
                y += contactbox.Height + 20; // Incrementa Y para la siguiente tarjeta

                contactbox.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag, true);
                };
                contactbox.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)contactbox.Tag);
                };
                contactbox.MouseHover += (sender, e) =>
                {
                    mensjaViejo = lblResultado.Text;
                    lblResultado.Text = "Haz doble click para ver los detalles del contacto";
                };
                contactbox.MouseLeave += (sender, e) =>
                {
                    lblResultado.Text = mensjaViejo;
                };

                PictureBox picturebox = new PictureBox
                {
                    Location = new Point(20, 10),
                    Tag = contacto.IdContacto,
                    BackgroundImage = Image.FromFile("usuario.png"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Size = new Size(50, 50) // Ajusta el tamaño del PictureBox
                };
                picturebox.Click += (sender, e) =>
                {
                    FocusCard((int)picturebox.Tag, true);
                };
                picturebox.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)picturebox.Tag);
                };

                Label Nombre = new Label
                {
                    Text = contacto.Nombre,
                    Tag = contacto.IdContacto,
                    Location = new Point(10, 70) // Posición relativa al interior del GroupBox
                };
                Nombre.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag, true);
                };
                Nombre.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)contactbox.Tag);
                };

                Label Gmail = new Label
                {
                    Text = contacto.Email ?? "---",
                    Tag = contacto.IdContacto,
                    Location = new Point(10, 100) // Posición relativa al interior del GroupBox
                };
                Gmail.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag, true);
                };
                Gmail.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)contactbox.Tag);
                };

                int yTelefono = 160;
                Label Grupo = null;
                if (contacto.Grupos != null)
                {
                    Grupo = new Label
                    {
                        Text = "Nombre grupo: " + contacto.Grupos.NombreGrupo ?? "---",
                        Tag = contacto.IdContacto,
                        Location = new Point(10, 130), // Posición relativa al interior del GroupBox
                        AutoSize = true
                    };
                    Grupo.Click += (sender, e) =>
                    {
                        FocusCard((int)contactbox.Tag, true);
                    };
                    Grupo.MouseDoubleClick += (sender, e) =>
                    {
                        Detalles((int)contactbox.Tag);
                    };
                }
                else
                {
                    yTelefono = 130;
                }

                Label Telefonos = new Label
                {
                    Text = "Número de \nteléfonos: " + contacto.Telefonos.Count,
                    Tag = contacto.IdContacto,
                    Location = new Point(10, yTelefono), // Posición relativa al interior del GroupBox
                    AutoSize = true
                };
                Telefonos.Click += (sender, e) =>
                {
                    FocusCard((int)contactbox.Tag, true);
                };
                Telefonos.MouseDoubleClick += (sender, e) =>
                {
                    Detalles((int)contactbox.Tag);
                };

                panel1.Controls.Add(Titulo);
                contactbox.Controls.Add(picturebox);
                contactbox.Controls.Add(Nombre);
                contactbox.Controls.Add(Gmail);
                if (contacto.Grupos != null) contactbox.Controls.Add(Grupo);
                contactbox.Controls.Add(Telefonos);

                panel1.Controls.Add(contactbox);
            }
        }

        private void FocusCard(int idSeleccionado, Boolean? dgv = false)
        {

            GroupBox seleccionado = new GroupBox();
            // Resetea el color de todos los GroupBox
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is GroupBox && ctrl.Tag.ToString() != idSeleccionado.ToString())
                {
                    ctrl.BackColor = Color.White;
                }
                else if (ctrl.Tag.ToString() == idSeleccionado.ToString())
                {
                    seleccionado = (GroupBox)ctrl;
                }
            }

            // Cambia el color del GroupBox seleccionado
            seleccionado.BackColor = Color.LightBlue;
            Focus(); //stack over flow

        }

        private void txtNombreContacto_TextChanged(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            CrearCards();

        }

<<<<<<< HEAD
        private void frmDarAltaContacto_Load_1(object sender, EventArgs e)
        {
            CrearCards();
        }

        private void txtNombreContacto_TextChanged_1(object sender, EventArgs e)
        {
            CrearCards();
        }

        private void btnEliminarTelef_Click(object sender, EventArgs e)
        {
            int index= cboTelefonos.SelectedIndex;
            if (index != -1)
            {
                Telefonos telefonoSeleccionado = telefonos.ElementAt(index);
                telefonos.Remove(telefonoSeleccionado);
                lblResultado.Text = $"El teléfono {telefonoSeleccionado.Numero} se ha eliminado correctamente";
                ActualizarTelefonos();
            }
            else
            {
                lblResultado.Text = "Selecciona un teléfono para eliminar";
            }
            
        }
        private String msgViejo;
        private void HoverEliminarTelefono()
        {
            msgViejo= lblResultado.Text;
            lblResultado.Text = "info: selecciona un teléfono que desees y click para eliminar";
            
        }
        private void QuitarHoverEliminarTelefono()
        {
            lblResultado.Text=msgViejo;
        }

        private void btnEliminarTelef_MouseHover(object sender, EventArgs e)
        {
            HoverEliminarTelefono(); 
        }

        private void btnEliminarTelef_MouseLeave(object sender, EventArgs e)
        {
            QuitarHoverEliminarTelefono();
        }

        private void cboTelefonos_MouseHover(object sender, EventArgs e)
        {
            HoverEliminarTelefono();
        }

        private void cboTelefonos_MouseLeave(object sender, EventArgs e)
        {
            QuitarHoverEliminarTelefono();

=======
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
>>>>>>> 74cdb057857c79e162037fb64e8607481ab77f61
        }
    }
}
