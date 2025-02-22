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

        [Required]
        public string IdRol { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string IdDepartamento { get; set; }

        // Relación con Departamento
        [ForeignKey(nameof(IdDepartamento))]
        public Departamento Departamento { get; set; }

        // Relación con Rol
        [ForeignKey(nameof(IdRol))]
        public Rol Rol { get; set; }
        // Relación con Directorio
        public ICollection<Directorio> Directorios { get; set; }
        // Relación con LineaCelular
        public ICollection<LineaCelular> LineaCelulares { get; set; }
        // Relación con LineaTelefono
        public ICollection<LineaTelefono> LineaTelefonos { get; set; }
        // Relación con LineaTelefono
        public ICollection<Telefono> Telefonos { get; set; }
        // Relación con EquiposDaniado
        public ICollection<EquiposDaniado> equiposDaniados { get; set; }
        // Relación con Movil
        public ICollection<Movil> Moviles { get; set; }
        // Relación con Monitor
        public ICollection<Monitor> Monitores { get; set; }
    }
}
