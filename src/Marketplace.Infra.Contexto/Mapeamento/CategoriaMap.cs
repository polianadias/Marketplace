using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Marketplace.Dominio.Entidades;

namespace Marketplace.Infra.Contexto.Mapeamento
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Descricao)
                 .HasColumnType("varchar(200)");

            builder.ToTable("Categorias");
        }
    }
}
