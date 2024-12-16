using Entidades;
using Servidores;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace GestionAgenda
{
    public class Gestion
    {
        MiAgendaEntities miAgendaEntities;

        // TODO: Constructor: Intenta crear un objeto de la clase Entities y si se
        // provoca error de ejecución lo devolverá al exterior.
        public Gestion() {
            try
            {
                string servidor = Servidor.ServidorActual();
                string cadenaConexion = $@"metadata = res://*/ModeloAgenda.csdl|res://*/ModeloAgenda.ssdl|res://*/ModeloAgenda.msl; provider = System.Data.SqlClient;provider connection string= 'data source={servidor};initial catalog=Agenda;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework'";
                miAgendaEntities = new MiAgendaEntities(cadenaConexion); // Modificar el constructor
            }
            catch (Exception exc)
            {
                // instrucciones ante el error
            }
        }

        // Devolver TODOS los contactos ordenados alfabéticamente
        public List<Contactos> ContactosOrdenados()
        {
            return miAgendaEntities.Contactos.OrderBy(con => con.Nombre).ToList();
        }

        // Devolver el contacto correspondiente a un identificador pasado como parámetro.
        public List<Contactos> ContactoPorId(int id)
        {
            return miAgendaEntities.Contactos.Select(con => con).Where(con => con.IdContacto == id).ToList();
        }

        // Dar de alta un grupo


        //Dar de alta un contacto
        public String AnyadirContacto()
        {
            return "";
        }
    }
}
