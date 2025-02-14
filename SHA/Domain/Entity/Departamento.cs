using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class Departamento
    {
        [Key]

        public string Id { get; set; }
        public string NomDpto { get; set; }
        public string Posicion { get; set; }

        //Relacion
        public ICollection <Usuario> Usuarios { get; set; }
    }
}

