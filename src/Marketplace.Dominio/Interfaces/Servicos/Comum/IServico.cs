using System.Linq.Expressions;

namespace Marketplace.Dominio.Interfaces.Servicos.Comum
{
    public interface IServico<TEntity> where TEntity : class
    {

        Task<IEnumerable<TEntity>> ObterTodos();

        Task<TEntity?> ObterPorId(Guid id);

        Task<IEnumerable<TEntity>> Buscar<TOrderKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TOrderKey>>? orderBy = null);

        Task Atualizar(TEntity entity);

        Task Adicionar(TEntity entity);

        Task Excluir(TEntity entity);
    }
}
