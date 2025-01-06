using Entidades;
using Servidores;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.ModelConfiguration.Configuration;
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
        public Gestion(out string mensaje) {
            mensaje = "";
            try
            {
                string servidor = Servidor.ServidorActual();
                string cadenaConexion = $@"metadata = res://*/ModeloAgenda.csdl|res://*/ModeloAgenda.ssdl|res://*/ModeloAgenda.msl; provider = System.Data.SqlClient;provider connection string= 'data source={servidor};initial catalog=Agenda;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework'";
                miAgendaEntities = new MiAgendaEntities(cadenaConexion); // Modificar el constructor
            }
            catch (Exception ex)
            {
                mensaje = $"Error al inicializar AgendaEntities: {ex.Message}";
                miAgendaEntities = null;
            }
        }

        // 2. Devolver TODOS los contactos ordenados alfabéticamente
        public List<Contactos> ContactosOrdenados()
        {
            return miAgendaEntities.Contactos.OrderBy(con => con.Nombre).ToList();
        }

        // 3. Devolver el contacto correspondiente a un identificador pasado como parámetro.
        public Contactos ContactoPorId(int id)
        {
            return miAgendaEntities.Contactos.FirstOrDefault(con => con.IdContacto == id);
        }

        // 4. Dar de alta un grupo
        public String anyadirGrupos(String nombreGrupo)
        {
            var contactosDuplicados = miAgendaEntities.Grupos.Select(gru => gru).Where(gru => gru.NombreGrupo.Equals(nombreGrupo)).ToList();
            if (contactosDuplicados.Count() != 0)
            {
                return $"El grupo {nombreGrupo} ya existe.";
            }

            Grupos grupoNuevo = new Grupos(nombreGrupo);
            miAgendaEntities.Grupos.Add(grupoNuevo);
            int nAfectados = miAgendaEntities.SaveChanges();


            return "";
        }

        // 5 Añadir un nuevo teléfono a un contacto
        public String AnyadirTelefonoContacto(int idContacto, Telefonos telefono)
        {
            String msg = "";
            try
            {

                var contacto = miAgendaEntities.Contactos.Find(idContacto);
                if (contacto == null)
                {
                    msg = "El contacto de id " + idContacto + " no existe.";
                    return msg;
                }
                if (contacto.Telefonos.Contains(telefono))
                {
                    msg = "El teléfono ya existe para el contacto.";
                    return msg;
                }

                if (string.IsNullOrWhiteSpace(telefono.Numero) && telefono.Numero.All(char.IsDigit) && telefono.Numero.Length >= 3)
                {
                    msg = "El número de teléfono no es válido.";
                    return msg;
                }
                contacto.Telefonos.Add(telefono);
                miAgendaEntities.SaveChanges();
            }
            catch (Exception ex)
            {
                msg = "Error al anyadir teléfono: " + ex.Message;
            }
            return msg;

        }

        // 6. Dar de alta un contacto
        public String AnyadirContacto(Contactos contacto)
        {
            //Controles del nombre
            if (String.IsNullOrWhiteSpace(contacto.Nombre))
            {
                return "El nombre no puede quedar vacio";
            }
            var contactosNombre = miAgendaEntities.Contactos.Select(con => con).Where(con => con.Nombre.ToLower() == contacto.Nombre.ToLower()).ToList();
            if (contactosNombre.Count() != 0)
            {
                return $"Ya existe un contacto con el nombre '{contacto.Nombre}'";
            }
            //Controles del grupo
            if (contacto.IdGrupo != -1)
            {
                var grupoDeId = miAgendaEntities.Grupos.Single(gru => gru.IdGrupo == contacto.IdGrupo);
                if (grupoDeId == null)
                {
                    return $"El grupo de id '{contacto.IdGrupo}' no existe";
                }
            }
            //Controles del email
            if (contacto.Email != null && !EmailValido(contacto.Email))
            {
                return "El email no es válido. Tiene que ser de la forma: < *@*.* >, sin espacios y con 5<numCaracteres<30";
            }
            //Controles de los telefonos
            if (contacto.Telefonos != null)
            {

                if (contacto.Telefonos.GroupBy(tel => tel).Any(tel => tel.Count() > 1))
                {
                    return $"No puede haber números de teléfono repetidos";
                }
                if (contacto.Telefonos.Any(tel => tel.Numero.Length < 3))
                {
                    return $"No puede haber números de teléfono con menos de 3 dígitos";
                }
            }

            miAgendaEntities.Contactos.Add(contacto);
            int nAfectados = miAgendaEntities.SaveChanges();
            return "";
        }

        /*solo cambio esto
         *
         * Contiene @ y no acaba ni empieza así        
         * Acaba con .*** o .** pero ni empieza ni acaba en .
         * No tiene espacios
         * No tiene menos de 6 ni más de 30
         */
        private Boolean EmailValido(String email)
        {
            return email.Contains("@") && email.Substring(email.Length - 4, 4).Contains(".") && !email.Contains(" ") && email.Length >= 6 && email.Length <= 30 && !email.StartsWith(".") && !email.EndsWith(".") && !email.EndsWith("@") && !email.StartsWith("@");
        }
        // 7. Borrar un teléfono
        public String BorrarTelefono(int idContacto, string numeroTelefono)
        {
            string msg = "";
            try
            {
                var telefono = miAgendaEntities.Telefonos.SingleOrDefault(telef => telef.IdContacto == idContacto && telef.Numero == numeroTelefono);
                if (telefono == null)
                {
                    msg = "El teléfono no existe para el contacto.";
                    return msg;
                }

                miAgendaEntities.Telefonos.Remove(telefono);
                miAgendaEntities.SaveChanges();


            }
            catch (Exception ex)
            {
                msg = "Error al borrar teléfono: " + ex.Message;
            }
            return msg;
        }

        // 8. Borrar un contacto con sus teléfonos
        public String BorrarContacto(int idContacto)
        {
            string msg = "";
            try
            {
                var contacto = miAgendaEntities.Contactos.Find(idContacto);
                if (contacto == null)
                {
                    msg = "El contacto no existe.";
                    return msg;
                }
                var telefonos = miAgendaEntities.Telefonos.Where(telef => telef.IdContacto == idContacto).ToList();
                miAgendaEntities.Telefonos.RemoveRange(telefonos);
                miAgendaEntities.Contactos.Remove(contacto);
                miAgendaEntities.SaveChanges();

                msg = $"Contacto {contacto.Nombre} y sus teléfonos eliminados correctamente.";

            }
            catch (Exception ex)
            {
                msg = "Error al borrar el contacto: " + ex.Message;
            }
            return msg;

        }

        // Devolver los Teléfonos de un contácto 
        public List<Telefonos> TelefonosDeUnContacto(int idContacto)
        {
            Contactos contactoBuscado = ContactoPorId(idContacto);
            return miAgendaEntities.Telefonos.Where(tel => tel.Contactos.IdContacto.Equals(idContacto)).ToList();

        }

        // Devolver los Contactos de un Teléfono 
        public List<Contactos> ContactosDeTelefono(string numeroTelefono, out string msg)
        {
            msg="";
            try
            {
                return miAgendaEntities.Contactos.Where(cont => cont.Telefonos.Any(tel => tel.Numero == numeroTelefono)).ToList();

            }catch (Exception exc) {
                msg = "Error al obtener los contactos de un teléfono: "+ exc.Message;
                msg = "Error al obtener los contactos de un teléfono: "+ exc.Message;
                return null;
            }
        }



        // Devolver TODOS los Grupos ordenados alfabéticamente
        public List<Grupos> GruposOrdenados()
        {
            return miAgendaEntities.Grupos.OrderBy(gru => gru.NombreGrupo).ToList();
        }

        // Borrar un grupo
        public String BorrarGrupo(Grupos grupo)
        {
            string msg = "";
            try
            {
                miAgendaEntities.Grupos.Remove(grupo);
                miAgendaEntities.SaveChanges();
                msg = $"Grupo {grupo.NombreGrupo} eliminado correctamente";
            }
            catch (Exception exc)
            {
                msg = "Error al borrar el Grupo: " + exc.Message;
            }
            return msg;
        }

        //Editar contacto
        public String EditarContacto(Contactos contacto)
        {
            string msg = "";
            try
            {
                var contactoAEditar= miAgendaEntities.Contactos.Find(contacto.IdContacto);
                if (contactoAEditar == null)
                {
                    return "El contacto no existe.";
                }


                contactoAEditar.Nombre = contacto.Nombre;
                
                contactoAEditar.Email = contacto.Email;

                CambiarGrupoContacto(contactoAEditar, contacto.IdGrupo);

                miAgendaEntities.SaveChanges();
                msg = $"Contacto {contacto.Nombre} editado correctamente";
            }
            catch (Exception exc)
            {
                msg = "Error al editar el contacto: " + exc.Message;
            }
            return msg;
        }

        //Cambiar el grupo de un contacto
        public string CambiarGrupoContacto(Contactos contacto,  int? idNuevoGrupo)
        {
            string msg = "";
            try
            {
             
                var grupo = miAgendaEntities.Grupos.Find(idNuevoGrupo);
                if (grupo == null)
                {
                    return "El grupo especificado no existe.";
                }

                contacto.IdGrupo = idNuevoGrupo;
                miAgendaEntities.SaveChanges();

                return $"El contacto {contacto.Nombre} ha cambiado al grupo {grupo.NombreGrupo}.";
            }
            catch (Exception exc)
            {
                msg="Error al cambiar el grupo del contacto: " + exc.Message;
                
            }
            return msg;
        }


        public Boolean ExisteGrupo(int idGrupo)
        {
            if (miAgendaEntities.Grupos.Any(grup => grup.IdGrupo == idGrupo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String EditarGrupo(int idGrupo, string nuevoNombre)
        {
            string msg = "";
            if (ExisteGrupo(idGrupo))
            {
                try
                {
                    Grupos grupo = miAgendaEntities.Grupos.Single(grup => grup.IdGrupo == idGrupo);
                    grupo.NombreGrupo = nuevoNombre;
                    miAgendaEntities.SaveChanges();
                }
                catch (Exception exc)
                {
                    msg = "Error al editar el Grupo: " + exc.Message;
                    return msg;
                }
                return msg;
            }
            return "No existe el grupo seleccionado con id: " + idGrupo;
        }

        public String AñadirContactoAGrupo(int idGrupo, int idContacto)
        {
            Grupos grupo = miAgendaEntities.Grupos.SingleOrDefault(gru => gru.IdGrupo == idGrupo);
            if (grupo != null) grupo.Contactos.Add(ContactoPorId(idContacto));
            miAgendaEntities.SaveChanges();
            return "";
        }

        public String SacarContactoDeGrupo(int idGrupo, int idContacto)
        {
            Grupos grupo = miAgendaEntities.Grupos.SingleOrDefault(gru => gru.IdGrupo == idGrupo);
            if (grupo == null || !grupo.Contactos.Remove(ContactoPorId(idContacto))) return "El grupo no existe o el contacto no está en el grupo";
            grupo.Contactos.Remove(ContactoPorId(idContacto));
            miAgendaEntities.SaveChanges();
            return "";
        }

    }
}
