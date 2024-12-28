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


        public static Gestion gestion = new Gestion();
        [STAThread]
        static void Main()
        {
            gestion = new Gestion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
