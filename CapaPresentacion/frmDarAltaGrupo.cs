using Entidades;
using GestionAgenda;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDarAltaGrupo : Form
    {
        List<Telefonos> telefonos;
        Gestion gestion;
        public frmDarAltaGrupo()
        {
            InitializeComponent();
            telefonos = new List<Telefonos>();
            gestion = Program.gestion;

            if (gestion == null)
            {
                MessageBox.Show("La inicialización de la aplicación ha fallado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();  
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
                    txtAñadirGrupo.Text = "";
                    CrearCards();
                }
            }
            
        }

        private String mensjaViejo;
        private void CrearCards()
        {

            List<Grupos> gruposExistentes;
            if (txtAñadirGrupo.Text == "")
            {
                gruposExistentes = gestion.GruposOrdenados();
            }
            else
            {
                gruposExistentes = gestion.GruposOrdenados().Where(grup => grup.NombreGrupo.ToLower().StartsWith(txtAñadirGrupo.Text.ToString().ToLower())).ToList();
                if (!gruposExistentes.Any(grup => grup.NombreGrupo.ToLower().Equals(txtAñadirGrupo.Text.ToLower()))) lblResultado.Text = "info: Nombre válido: no hay grupos con ese nombre";
                else lblResultado.Text = "info: Nombre NO valido: hay grupos con ese nombre";
            }

            Label Titulo = new Label
            {
                Tag = "Titulo",
                Location = new Point(panel1.AutoScrollPosition.X, panel1.AutoScrollPosition.Y),
                AutoSize = true
            };
            if (gruposExistentes.Count == 0)
            {
                Titulo.Text = "No hay grupos que empiezan como: " + txtAñadirGrupo.Text;
            }
            else if (!String.IsNullOrEmpty(txtAñadirGrupo.Text))
            {
                Titulo.Text = "Grupos que empiezan como: " + txtAñadirGrupo.Text;
            }
            else
            {
                Titulo.Text = "Todos los grupos";
            }

            panel1.Controls.Clear();
            int x = panel1.AutoScrollPosition.X + 20; // Eje X fijo
            int y = panel1.AutoScrollPosition.Y + 40; // Eje Y dinámico

            
            for (int i = 0; i < gruposExistentes.Count; i++)
            {
                Color colorFondo = ColoritosCards();
                Grupos grupo = gruposExistentes[i];
                GroupBox contactbox = new GroupBox
                {
                    Name = "grupo " + grupo.IdGrupo,
                    Tag = grupo.IdGrupo,
                    Size = new Size(150, 100), // Ajusta el tamaño según sea necesario
                    Location = new Point(x, y), // Posición relativa
                    BackColor = colorFondo
                };
                y += contactbox.Height + 20; // Incrementa Y para la siguiente tarjeta
              

                PictureBox picturebox = new PictureBox
                {
                    Location = new Point(45, 0),
                    Tag = grupo.IdGrupo,
                    BackgroundImage = Image.FromFile("grupos.png"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Size = new Size(50, 50), // Ajusta el tamaño del PictureBox
                    BackColor= colorFondo

                };

                Label Nombre = new Label
                {
                    Text = grupo.NombreGrupo,
                    Tag = grupo.IdGrupo,
                    Location = new Point(10, 50), // Posición relativa al interior del GroupBox
                    BackColor=colorFondo

                };
               
                int numCont = gestion.ContactosOrdenados().Where(con => con.Grupos != null && con.Grupos.IdGrupo == grupo.IdGrupo).Count();
                Label numContacto = new Label
                {
                    Text = "Número de contactos: "+ numCont ,
                    Tag = grupo.IdGrupo,
                    AutoSize = true,    
                    Location = new Point(10, 70), // Posición relativa al interior del GroupBox
                    BackColor=colorFondo
                };
               

                panel1.Controls.Add(Titulo);
                contactbox.Controls.Add(picturebox);
                contactbox.Controls.Add(Nombre);
                contactbox.Controls.Add(numContacto);
              

                panel1.Controls.Add(contactbox);
            }
        }
        

        private void frmDarAltaGrupo_Load(object sender, EventArgs e)
        {
            CrearCards();
        }

        private void txtAñadirGrupo_TextChanged(object sender, EventArgs e)
        {
            CrearCards();
        }
        private HashSet<Color> coloresGenerados = new HashSet<Color>();
        private Color ColoritosCards()
        {           
            int cantGrup= gestion.GruposOrdenados().Count();
           Color colorPastel;
                do
                {
                    colorPastel = GenerarColorPastel();
                } while (coloresGenerados.Contains(colorPastel));

            coloresGenerados.Add(colorPastel);
            return colorPastel;
    
        }
        
        private Color GenerarColorPastel()
        {
            Random random = new Random();

            int red = random.Next(150, 256); 
            int green = random.Next(150, 256);
            int blue = random.Next(150, 256); 

            return Color.FromArgb(red, green, blue);
        }
    }
}
