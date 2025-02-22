using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SHA.Domain.Entity
{
    public class EquiposDaniado
    {
        [Key]
        public string Id { get; set; }
        public int Numero { get; set; }
        public string Equipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string MacEthernet { get; set; }
        public string MacWifi { get; set; }
        public string Procesador { get; set; }
        public string RAM { get; set; }
        public string SSD { get; set; }
        public string Comentario { get; set; }
        public string IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public string IdDepartamento { get; set; }

        // Relación con Empresa
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        // Relación con Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        // Relación con Departamento
        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }


    }
}
