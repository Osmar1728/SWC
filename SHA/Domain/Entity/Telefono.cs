using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class Telefono
    {
        [Key]
        public string Id { get; set; }

        public string Numero { get; set; }

        public string Tipo { get; set; }

        public string Modelo { get; set; }

        public string Cabina { get; set; }

        public string IdUsuario { get; set; }

        public string IdDepartamento { get; set; }

        // Relación con Departamento
        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }
        // Relación con Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
    }
}
