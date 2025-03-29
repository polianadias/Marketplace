using Marketplace.Dominio.Entidades;
using Marketplace.Dominio.Interfaces.Repositorio;
using Marketplace.Dominio.Interfaces.Servicos;
using Marketplace.Dominio.Servicos.Comum;

namespace Marketplace.Dominio.Servicos
{
    public class CategoriaServico : Servico<Categoria>, ICategoriaService
    {
        public CategoriaServico(ICategoriaRepositorio repositorio) : base(repositorio)
        {
        }
    }
}
