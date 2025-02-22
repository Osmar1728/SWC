using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHA.Domain.Entity
{
    public class Printek
    {
        [Key]
        public string Id { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public string Ip { get; set; }
        public string Ubicacion { get; set; }
        [Required]
        public string IdDepartamento { get; set; }

        // Relación con Departamento
        [ForeignKey(nameof(IdDepartamento))]
        public Departamento Departamento { get; set; }
    }
}
