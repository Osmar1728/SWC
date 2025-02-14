using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHA.Domain.Entity
{
    public class Usuario
    {
        [Key]
        public string Id { get; set; }
        public string Token { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string User { get; set; }
        public string IdRol { get; set; }
        public string Password { get; set; }
        public string IdDepartamento { get; set; }

        //Relacion
        [ForeignKey("Departamento")]
        public Departamento Departamentos { get; set; }

        [ForeignKey("Rol")]
        public Rol Roles { get; set; }


    }
}
