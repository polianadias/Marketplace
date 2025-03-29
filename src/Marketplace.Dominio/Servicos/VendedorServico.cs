using Marketplace.Dominio.Entidades;
using Marketplace.Dominio.Interfaces.Repositorio;
using Marketplace.Dominio.Interfaces.Servicos;
using Marketplace.Dominio.Servicos.Comum;

namespace Marketplace.Dominio.Servicos
{
    public class VendedorServico : Servico<Vendedor>, IVendedorService
    {
        public VendedorServico(IVendedorRepositorio repositorio) : base(repositorio)
        {
        }
    }
}
