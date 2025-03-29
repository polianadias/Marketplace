using System.Linq.Expressions;
using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;

namespace Marketplace.Aplicacao
{
    public class VendedorAppService : IVendedorAppService
    {
        private readonly IVendedorAppService _service;

        public VendedorAppService(IVendedorAppService service)
        {
            _service = service;
        }

        public Vendedor Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<Vendedor> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Vendedor> Find(Expression<Func<Vendedor, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Add(Vendedor vendedor)
        {
            _service.Add(vendedor);
        }

        public void Update(Vendedor vendedor)
        {
            _service.Update(vendedor);
        }

        public void Delete(Vendedor vendedor)
        {
            _service.Delete(vendedor);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
