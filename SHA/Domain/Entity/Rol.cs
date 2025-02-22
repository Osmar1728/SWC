using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class Rol
    {
        [Key]

        public string Id { get; set; }
        public string Roles {  get; set; }
        public bool Estado { get; set; }

        //Relacion 

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
