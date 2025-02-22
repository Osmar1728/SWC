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

        // Relación con Directorio
        public ICollection<Directorio> Directorios { get; set; }

        // Relación con LineaCelular
        public ICollection<LineaCelular> LineaCelulares { get; set; }
        // Relación con LineaTelefono
        public ICollection<LineaTelefono> LineaTelefonos { get; set; }
        // Relación con Telefono
        public ICollection<Telefono> Telefonos { get; set; }
        // Relación con Tablet
        public ICollection<Tablet> Tablets { get; set; }
        // Relación con EquiposDaniado
        public ICollection<EquiposDaniado> equiposDaniados { get; set; }
        // Relación con Movil
        public ICollection<Movil> Moviles { get; set; }
        // Relación con Monitor
        public ICollection<Monitor> Monitores { get; set; }
    }
}

