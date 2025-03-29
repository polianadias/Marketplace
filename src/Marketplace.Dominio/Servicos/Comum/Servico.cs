using System.Linq.Expressions;
using Marketplace.Dominio.Interfaces.Repositorio.Comum;
using Marketplace.Dominio.Interfaces.Servicos.Comum;

namespace Marketplace.Dominio.Servicos.Comum
{
    public class Servico<TEntity> : IServico<TEntity> where TEntity : class
    {
        private readonly IRepositorio<TEntity> _repositorio;

        public Servico(IRepositorio<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public Task Adicionar(TEntity entity)
        {
          return  _repositorio.Adicionar(entity);
        }

        public Task Atualizar(TEntity entity)
        {
           return _repositorio.Atualizar(entity);
        }

        public Task<IEnumerable<TEntity>> Buscar<TOrderKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TOrderKey>>? orderBy = null)
        {
           return _repositorio.Buscar(predicate, orderBy);    
        }

        public Task Excluir(TEntity entity)
        {
            return _repositorio.Excluir(entity);
        }

        public Task<TEntity?> ObterPorId(Guid id)
        {
            return _repositorio.ObterPorId(id);
        }

        public Task<List<TEntity>> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }
    }
}
