using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class Impresora
    {
        [Key]
        public string Id { get; set; }
        public int Numero { get; set; }
        public string Modelo { get; set; }
        public string Ubicacion { get; set; }
        public string Cabina { get; set; }
        public decimal Precio { get; set; }
    }
}
