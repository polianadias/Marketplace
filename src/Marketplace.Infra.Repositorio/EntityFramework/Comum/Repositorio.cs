using Marketplace.Dominio.Interfaces.Repositorio.Comum;
using Marketplace.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Marketplace.Infra.Repositorio.EntityFramework.Comum
{
    public abstract class Repositorio<TEntity> : IRepositorio<TEntity>, IDisposable where TEntity : class
    {
        protected EFDbContext dbContext;
        protected DbSet<TEntity> DbSet { get; set; }

        public Repositorio(EFDbContext dbContext)
        {
            this.dbContext = dbContext;
            DbSet = this.dbContext.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<TEntity?> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> Buscar<TOrderKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TOrderKey>>? orderBy = null)
        {
            var query = DbSet.Where(predicate).AsQueryable();

            if (orderBy != null)
            {
                query = query.OrderBy(orderBy);
            }
            return await query.ToListAsync();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await dbContext.SaveChangesAsync();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Excluir(TEntity entity)
        {
            DbSet.Remove(entity);
            await dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            dbContext?.Dispose();
        }
    }
}
