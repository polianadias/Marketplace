using System.Linq.Expressions;

namespace Marketplace.Dominio.Interfaces.Repositorio.Comum
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        Task<List<TEntity>> ObterTodos();

        Task<TEntity?> ObterPorId(Guid id);

        Task<IEnumerable<TEntity>> Buscar<TOrderKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TOrderKey>>? orderBy = null);

        Task Atualizar(TEntity entity);

        Task Adicionar(TEntity entity);

        Task Excluir(TEntity entity);
    }
}
