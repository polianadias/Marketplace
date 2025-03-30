using System.Linq.Expressions;
using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;
using Marketplace.Dominio.Interfaces.Servicos;

namespace Marketplace.Aplicacao
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoService _service;

        public ProdutoAppService(IProdutoService service)
        {
            _service = service;
        }
        public Task Adicionar(Produto entity)
        {
            return _service.Adicionar(entity);
        }

        public Task Atualizar(Produto entity)
        {
            return _service.Atualizar(entity);
        }

        public Task<IEnumerable<Produto>> Buscar<TOrderKey>(Expression<Func<Produto, bool>> predicate, Expression<Func<Produto, TOrderKey>>? orderBy = null)
        {
            return _service.Buscar(predicate, orderBy);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task Excluir(Produto entity)
        {
            return _service.Excluir(entity);
        }

        public Task<Produto?> ObterPorId(Guid id)
        {
            return _service.ObterPorId(id);
        }

        public Task<IEnumerable<Produto>> ObterTodos()
        {
            return _service.ObterTodos();
        }
    }
}
