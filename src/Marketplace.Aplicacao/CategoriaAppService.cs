using System.Linq.Expressions;
using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;

namespace Marketplace.Aplicacao
{
    public class CategoriaAppService : ICategoriaAppService
    {
        private readonly ICategoriaAppService _service;

        public CategoriaAppService(ICategoriaAppService service)
        {
            _service = service;
        }

        public Categoria Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<Categoria> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Categoria> Find(Expression<Func<Categoria, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Add(Categoria categoria)
        {
            _service.Add(categoria);
        }

        public void Update(Categoria categoria)
        {
            _service.Update(categoria);
        }

        public void Delete(Categoria categoria)
        {
            _service.Delete(categoria);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
