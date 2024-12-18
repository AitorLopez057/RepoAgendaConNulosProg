//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Contactos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contactos()
        {
            this.Telefonos = new HashSet<Telefonos>();
        }

        public Contactos(String nombre, String email, int? idGrupo) : this()
        {
            Nombre = nombre;
            Email = email;
            IdGrupo = idGrupo;
        }
        public Contactos(int idContacto, String nombre, String email, int? idGrupo) : this()
        {
            IdContacto = idContacto;
            Nombre = nombre;
            Email = email;
            IdGrupo = idGrupo;
        }//Llamada constructor vacio


        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int? IdGrupo { get; set; }
    
        public virtual Grupos Grupos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telefonos> Telefonos { get; set; }


        public String toStringTelefonos()
        {
            String cadenaTelefonos = "";
            foreach (var tel in this.Telefonos)
            {
                cadenaTelefonos += tel.Numero + ",";
            }
            return cadenaTelefonos;
        }
    }
}
