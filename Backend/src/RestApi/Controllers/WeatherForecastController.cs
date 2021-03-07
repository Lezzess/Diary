using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dtos.WeatherForecast;
using Application.Requests.WeatherForecast.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public Task<List<WeatherForecastDto>> Get()
        {
            return _mediator.Send(new GetWeatherForecastRequest());
        }
    }
}
