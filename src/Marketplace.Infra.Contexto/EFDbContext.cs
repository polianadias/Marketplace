using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Infra.Contexto
{
    public class EFDbContext(DbContextOptions<EFDbContext> options) : IdentityDbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var property in builder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(200)");

            builder.ApplyConfigurationsFromAssembly(typeof(EFDbContext).Assembly);

            foreach (var relationShip in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationShip.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(builder);
        }
    }
}