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
        public List<Contactos> contactos()
        {
            return null;
        }

        //Dar de alta un contacto
        public String AnyadirContacto(Contactos contacto)
        {
            //Controles del nombre
            if (String.IsNullOrWhiteSpace(contacto.Nombre))
            {
                return "El nombre no puede quedar vacio";
            }
            var contactosNombre = miAgendaEntities.Contactos.Select(con => con).Where(con => con.Nombre.ToLower() == contacto.Nombre.ToLower()).ToList();
            if (contactosNombre.Count()!= 0)
            {
                return $"Ya existe un contacto con el nombre '{contacto.Nombre}'";
            }
            //Controles del grupo
            if (contacto.IdGrupo != null)
            {
                var grupoDeId = miAgendaEntities.Grupos.Single(gru => gru.IdGrupo == contacto.IdGrupo);
                if (grupoDeId == null)
                {
                    return $"El grupo de id '{contacto.IdGrupo}' no existe";
                }
            }
            //Controles de los telefonos
            if (contacto.Telefonos != null)
            {
                if (contacto.Telefonos.Count()>1)
                {
                    if (contacto.Telefonos.GroupBy(tel => tel).Any(tel => tel.Count() > 1) || contacto.Telefonos.Any(tel => tel.Numero.Count()<3))
                    {
                        return $"No puede haber números de teléfono repetidos o con menos de 3 dígitos";
                    }

                }
            }
            return "";
        }
        public String AnyadirTelefonoContacto()
        {
            return "";

        }
    }
}
