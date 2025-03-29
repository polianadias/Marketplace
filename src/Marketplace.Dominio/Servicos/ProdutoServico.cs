using Marketplace.Dominio.Entidades;
using Marketplace.Dominio.Interfaces.Repositorio;
using Marketplace.Dominio.Interfaces.Servicos;
using Marketplace.Dominio.Servicos.Comum;

namespace Marketplace.Dominio.Servicos
{
    public class ProdutoServico : Servico<Produto>, IProdutoService
    {
        public ProdutoServico(IProdutoRepositorio repositorio) : base(repositorio)
        {
        }
    }
}
