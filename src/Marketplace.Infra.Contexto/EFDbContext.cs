using Marketplace.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Infra.Contexto
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Vendedor> Vendedors { get; set; }

    }
}