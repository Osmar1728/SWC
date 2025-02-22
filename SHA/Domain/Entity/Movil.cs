using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHA.Domain.Entity
{
    public class Movil
    {
        [Key]
        public string Id { get; set; }
        public int Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public string NumCelular { get; set; }
        public decimal Megas { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioPlan { get; set; }
        public string Comentario {  get; set; }
        public string IdUsuario { get; set; }
        public string IdDepartamento { get; set; }
        public string IdEmpresa { get; set; }

        // Relación con Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        // Relación con Departamento
        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }
        // Relación con Empresa
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }
    }
}
