using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;


namespace Marketplace.Servicos.REST.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoAppService _appServico;

        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(ILogger<ProdutoController> logger, IProdutoAppService appServico)
        {
            _logger = logger;
            _appServico = appServico;
        }

        [HttpGet]
        public Task<IEnumerable<Produto>> Get()
        {
            return _appServico.ObterTodos();
        }

        [HttpGet("{id}")]
        public Task<Produto> Get(Guid id)
        {
            return _appServico.ObterPorId(id);
        }

        [HttpPost]
        public Task Post(Produto produto)
        {
            return _appServico.Adicionar(produto);
        }

        [HttpPut("{id}")]
        public Task Put(Produto produto)
        {
            return _appServico.Atualizar(produto);
        }

        [HttpDelete("{id}")]
        public Task Delete(Produto produto)
        {
            return _appServico.Excluir(produto);
        }
    }
}
