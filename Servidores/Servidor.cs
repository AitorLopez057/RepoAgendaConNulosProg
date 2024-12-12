using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidores
{
    public static class Servidor
    {
        private const string RUTADIRECTORIO = "./FicheroServidores";
        private const string RUTAFICHERO = "./FicheroServidores/Servidores.txt";

        private static void CrearFichero(string[] lineas)
        {
            File.WriteAllLines(RUTAFICHERO, lineas);
        }
        public static string ServidorActual ()
        {
            
            string[] servidoresPorDefecto = { "4V-PRO-948*4V-PRO-948\\SQLEXPRESS" };
            if (!Directory.Exists(RUTADIRECTORIO))
            {
                Directory.CreateDirectory(RUTADIRECTORIO);
                CrearFichero(servidoresPorDefecto); // todo Como luego vas a preguntar por el fichero esto aquí sobraría
            }
            if (!File.Exists(RUTAFICHERO))
            {
                CrearFichero(servidoresPorDefecto);
            }
            // TODO Si existía el fichero no controla que tenga la linea servidoresPorDefecto
            string[] lineas= File.ReadAllLines(RUTAFICHERO);
            bool reescribir=false;
            string servidorDeMaquina = "";
            foreach (string linea in lineas)
            {
                string[] lineaSeparada = linea.Split('*');
                if (lineaSeparada.Length != 2)
                {
                    lineas[Array.IndexOf(lineas, linea)]="";
                    reescribir = true; 
                }
                if (Environment.MachineName == lineaSeparada[0])
                {
                    servidorDeMaquina= lineaSeparada[1];
                }
            }
            if (reescribir)
            {
                File.Delete(RUTAFICHERO);
                CrearFichero(lineas);
            }
            if (!string.IsNullOrWhiteSpace( servidorDeMaquina))
            {
                return servidorDeMaquina;
            }
            return ".";
        }
    }
}
