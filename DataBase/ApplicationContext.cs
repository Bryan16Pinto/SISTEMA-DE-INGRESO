using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaEgresosIngresos.Enums;
using SistemaEgresosIngresos.Models.Entities;

namespace SistemaEgresosIngresos.DataBase
{
    public class ApplicationContext : IdentityDbContext<AppUsuario>
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUsuario> AppUsuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var hasher = new PasswordHasher<AppUsuario>();
            var defaultAdminUser = new AppUsuario
            {
                Id = "a6c6-9443d048cdb9-8e445865-a24d-4543",
                UserName = "brayan@hotmail.com",
                NormalizedUserName = "BRAYAN@HOTMAIL.COM",
                Email = "brayan@hotmail.com",
                NormalizedEmail = "BRAYAN@HOTMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "1q2w3e4r5t_"),
                Estado = true,
                EmailConfirmed = true
            };
            modelBuilder.Entity<AppUsuario>().HasData(defaultAdminUser);

            var administratorRole = new IdentityRole
            {
                Id = "a6c6-9443d048cdb9-8e445865-a24d-4345",
                Name = MiTiendaRol.ADMINISTRADOR.ToString(),
                NormalizedName = MiTiendaRol.ADMINISTRADOR.ToString().ToUpper()
            };
            var RoleVendedor= new IdentityRole
            {
                Id = "a6c6-9443d048cdb9-8e445865-a24d-4346",
                Name = MiTiendaRol.VENDEDOR.ToString(),
                NormalizedName = MiTiendaRol.VENDEDOR.ToString().ToUpper()
            };

            modelBuilder.Entity<IdentityRole>().HasData(administratorRole);
            modelBuilder.Entity<IdentityRole>().HasData(RoleVendedor);


            var userRoleAdmin = new IdentityUserRole<string>()
            {
                RoleId = administratorRole.Id,
                UserId = defaultAdminUser.Id
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoleAdmin);
        }

    }
}
