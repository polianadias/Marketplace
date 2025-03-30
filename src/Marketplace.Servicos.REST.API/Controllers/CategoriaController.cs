using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Servicos.REST.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaAppService _appServico;

        private readonly ILogger<CategoriaController> _logger;

        public CategoriaController(ILogger<CategoriaController> logger, ICategoriaAppService appServico)
        {
            _logger = logger;
            _appServico = appServico;
        }

        [HttpGet]
        public Task<IEnumerable<Categoria>> Get()
        {
            return _appServico.ObterTodos();
        }

        [HttpGet("{id}")]
        public Task<Categoria> Get(Guid id)
        {
            return _appServico.ObterPorId(id);
        }

        [HttpPost]
        public Task Post(Categoria categoria)
        {
            return _appServico.Adicionar(categoria);
        }

        [HttpPut("{id}")]
        public Task Put(Categoria categoria)
        {
            return _appServico.Atualizar(categoria);
        }

        [HttpDelete("{id}")]
        public Task Delete(Categoria categoria)
        {
            return _appServico.Excluir(categoria);
        }
    }
}
