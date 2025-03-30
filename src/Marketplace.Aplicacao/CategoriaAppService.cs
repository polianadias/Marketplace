using System.Linq.Expressions;
using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;
using Marketplace.Dominio.Interfaces.Servicos;

namespace Marketplace.Aplicacao
{
    public class CategoriaAppService : ICategoriaAppService
    {
        private readonly ICategoriaService _service;

        public CategoriaAppService(ICategoriaService service)
        {
            _service = service;
        }

        public Task Adicionar(Categoria entity)
        {
            return _service.Adicionar(entity);  
        }

        public Task Atualizar(Categoria entity)
        {
            return _service.Atualizar(entity);
        }

        public Task<IEnumerable<Categoria>> Buscar<TOrderKey>(Expression<Func<Categoria, bool>> predicate, Expression<Func<Categoria, TOrderKey>>? orderBy = null)
        {
           return _service.Buscar(predicate, orderBy);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task Excluir(Categoria entity)
        {
            return _service.Excluir(entity);
        }

        public Task<Categoria?> ObterPorId(Guid id)
        {
            return _service.ObterPorId(id);
        }

        public Task<IEnumerable<Categoria>> ObterTodos()
        {
           return _service.ObterTodos();
        }
    }
}
