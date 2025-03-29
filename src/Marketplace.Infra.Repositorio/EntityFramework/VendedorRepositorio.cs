using Marketplace.Dominio.Entidades;
using Marketplace.Dominio.Interfaces.Repositorio;
using Marketplace.Infra.Contexto;
using Marketplace.Infra.Repositorio.EntityFramework.Comum;

namespace Marketplace.Infra.Repositorio.EntityFramework
{
    public class VendedorRepositorio(EFDbContext dbContext) : Repositorio<Vendedor>(dbContext), IVendedorRepositorio
    {       
    }
}
