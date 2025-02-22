using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class LineaCelular
    {
        [Key]
        public string Id { get; set; }

        public string IdUsuario { get; set; }

        public string IdDepartamento { get; set; }

        public string Numero { get; set; }

        // Relación con Departamento
        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }
        // Relación con Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
    }
}
