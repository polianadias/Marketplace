using Marketplace.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Infra.Contexto
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options) { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }

    }
}