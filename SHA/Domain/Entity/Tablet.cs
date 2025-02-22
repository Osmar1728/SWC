using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class Tablet
    {
        [Key]
        public string Id { get; set; }
        public int Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string MacWifi { get; set; }
        public decimal Precio { get; set; }
        public string Cabina { get; set; }
        public string Comentarios { get; set; }

        // Relación con Departamento
        public string IdDepartamento { get; set; }
        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }

        // Relación con Empresa
        public string IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }
    }
}
