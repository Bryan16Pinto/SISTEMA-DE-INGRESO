using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaEgresosIngresos.Enums
{
    public enum MiTiendaRol
    {
        [Display(Name = "ADMINISTRADOR")]
        ADMINISTRADOR,
        [Display(Name = "VENDEDOR")]
        VENDEDOR
    }
}
