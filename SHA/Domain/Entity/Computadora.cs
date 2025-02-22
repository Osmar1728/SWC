using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHA.Domain.Entity
{
    public class Computadora
    {
        [Key]
        public string Id { get; set; }
        public int Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NomDispositivo { get; set; }
        public string NumeroSerie { get; set; }
        public string MacEthernet { get; set; }
        public string MacWifi { get; set; }
        public string Procesador { get; set; }
        public string Ram { get; set; }
        public string Ssd { get; set; }
        public decimal Precio { get; set; }
        public string Comentario { get; set; }
        public string IdEmpresa { get; set; }

        // Relación con Empresa
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }
    }
}
