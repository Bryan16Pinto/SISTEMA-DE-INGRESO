using SistemaEgresosIngresos.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaEgresosIngresos.Models.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public TipoCliente TipoCliente { get; set; }

        [Required(ErrorMessage = "El número de documento es requerido")]
        [MaxLength(20)]
        public string NumeroDocumento { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MaxLength (50)]
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        [MaxLength(50)]
        public string Correo { get; set; }

    }
}
