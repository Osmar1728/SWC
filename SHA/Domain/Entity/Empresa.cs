using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class Empresa
    {
        [Key]
        public string Id { get; set; }
        public string Nombre { get; set; }

        // Relación con Tablet
        public ICollection<Tablet> Tablets { get; set; }
        // Relación con EquiposDaniado
        public ICollection<EquiposDaniado> equiposDaniados { get; set; }
        // Relación con Movil
        public ICollection<Movil> Moviles { get; set; }
        // Relación con Monitor
        public ICollection<Monitor> Monitores { get; set; }
        public ICollection<Computadora> computadoras { get; set; }
        public ICollection<Laptop> laptops { get; set; }
    }
}
