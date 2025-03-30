using Marketplace.Dominio.Entidades;
using Marketplace.Dominio.Interfaces.Repositorio;
using Marketplace.Infra.Contexto;
using Marketplace.Infra.Repositorio.EntityFramework.Comum;

namespace Marketplace.Infra.Repositorio.EntityFramework
{
    public class ProdutoRepositorio : Repositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(EFDbContext dbContext) : base(dbContext) { }
    }
}
