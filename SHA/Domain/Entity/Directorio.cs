using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class Directorio
    {
        [Key]
        public string Id { get; set; }

        public string IdUsuario { get; set; }

        public string IdDepartamento { get; set; }

        public string NivelUbicacion { get; set; }

        public string Extension { get; set; }

        public string Cabina { get; set; }

        // Relación con Departamento
        [ForeignKey(nameof(IdDepartamento))]
        public Departamento Departamento { get; set; }

        // Relación con Usuario
        [ForeignKey(nameof(IdUsuario))]
        public Usuario Usuario { get; set; }
    }
}
