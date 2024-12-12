using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAgenda;

namespace CapaPresentacion
{
    internal static class Program
    {

        public static class GlobalConfig
        {
            public static Gestion Gestion { get; set; } = new Gestion();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
