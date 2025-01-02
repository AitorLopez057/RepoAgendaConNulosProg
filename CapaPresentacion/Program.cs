using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAgenda;

namespace CapaPresentacion
{
    public static class Program
    {

        public static Gestion gestion ;
        [STAThread]
        static void Main()
        {
            string mensaje = "";
            gestion = new Gestion(out mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error de inicialización");
                return; 
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
