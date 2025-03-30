using System.Linq.Expressions;
using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;
using Marketplace.Dominio.Interfaces.Servicos;

namespace Marketplace.Aplicacao
{
    public class VendedorAppService : IVendedorAppService
    {
        private readonly IVendedorService _service;

        public VendedorAppService(IVendedorService service)
        {
            _service = service;
        }

        public Task Adicionar(Vendedor entity)
        {
            return _service.Adicionar(entity);
        }

        public Task Atualizar(Vendedor entity)
        {
            return _service.Atualizar(entity);
        }

        public Task<IEnumerable<Vendedor>> Buscar<TOrderKey>(Expression<Func<Vendedor, bool>> predicate, Expression<Func<Vendedor, TOrderKey>>? orderBy = null)
        {
            return _service.Buscar(predicate, orderBy);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task Excluir(Vendedor entity)
        {
            return _service.Excluir(entity);
        }

        public Task<Vendedor?> ObterPorId(Guid id)
        {
            return _service.ObterPorId(id);
        }

        public Task<IEnumerable<Vendedor>> ObterTodos()
        {
            return _service.ObterTodos();
        }
    }
}
