using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;


namespace Marketplace.Servicos.REST.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorAppService _appServico;

        private readonly ILogger<VendedorController> _logger;

        public VendedorController(ILogger<VendedorController> logger, IVendedorAppService appServico)
        {
            _logger = logger;
            _appServico = appServico;
        }

        [HttpGet]
        public Task<IEnumerable<Vendedor>> Get()
        {
            return _appServico.ObterTodos();
        }

        [HttpGet("{id}")]
        public Task<Vendedor> Get(Guid id)
        {
            return _appServico.ObterPorId(id);
        }

        [HttpPost]
        public Task Post(Vendedor vendedor)
        {
            return _appServico.Adicionar(vendedor);
        }

        [HttpPut("{id}")]
        public Task Put(Vendedor vendedor)
        {
            return _appServico.Atualizar(vendedor);
        }

        [HttpDelete("{id}")]
        public Task Delete(Vendedor vendedor)
        {
            return _appServico.Excluir(vendedor);
        }
    }
}
