using Marketplace.Aplicacao.Interfaces;
using Marketplace.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Servicos.REST.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IProdutoAppService _appServico;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IProdutoAppService appServico)
        {
            _logger = logger;
            _appServico = appServico;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Task<IEnumerable<Produto>> Get()
        {
            return _appServico.ObterTodos();
        }
    }
}
