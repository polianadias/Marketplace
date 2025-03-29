using System.Linq.Expressions;
using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;

namespace Marketplace.Aplicacao
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoAppService _service;

        public ProdutoAppService(IProdutoAppService service)
        {
            _service = service;
        }
        public Produto Get(int id, bool @readonly = false)
        {
            return _service.Get(id, @readonly);
        }

        public IEnumerable<Produto> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Produto> Find(Expression<Func<Produto, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Add(Produto produto)
        {
            _service.Add(produto);
        }

        public void Update(Produto produto)
        {
            _service.Update(produto);
        }

        public void Delete(Produto produto)
        {
            _service.Delete(produto);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
