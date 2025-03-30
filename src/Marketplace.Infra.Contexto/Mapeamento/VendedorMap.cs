using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Marketplace.Dominio.Entidades;


namespace Marketplace.Infra.Contexto.Mapeamento
{
    public class VendedorMap : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.HasKey(t => t.Codigo);
            builder.Property(t => t.Nome)
                .HasMaxLength(160)
                .IsRequired();

            builder.ToTable("Vendedor");
        }
    }
}
