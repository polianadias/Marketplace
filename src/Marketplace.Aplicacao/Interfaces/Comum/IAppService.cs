using System.Linq.Expressions;

namespace Marketplace.Aplicacao.Interfaces.Comum
{
    public interface IAppServico<TEntity> : IDisposable where TEntity : class
    {
        TEntity Get(int id, bool @readonly = false);
        IEnumerable<TEntity> All(bool @readonly = false);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = false);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
