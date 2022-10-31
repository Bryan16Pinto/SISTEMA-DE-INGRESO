using Microsoft.AspNetCore.Identity;

namespace SistemaEgresosIngresos.Models.Entities
{
    public class AppUsuario : IdentityUser
    {
        public bool Estado { get; set; }
    }
}
