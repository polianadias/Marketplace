using Marketplace.Dominio.Interfaces.Servicos;
using Marketplace.Aplicacao;
using Marketplace.Dominio.Servicos;
using Microsoft.Extensions.DependencyInjection;
using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Interfaces.Repositorio;
using Marketplace.Infra.Repositorio.EntityFramework;

namespace Marketplace.Infra.CrossCutting.IoC
{
    public static class BootStrapper
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IProdutoService, ProdutoServico>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

        }
    }
}
