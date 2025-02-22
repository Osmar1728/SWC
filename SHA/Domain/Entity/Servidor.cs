using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class Servidor
    {
        [Key]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Ip { get; set; }
        public string Comentario { get; set; }
    }
}
