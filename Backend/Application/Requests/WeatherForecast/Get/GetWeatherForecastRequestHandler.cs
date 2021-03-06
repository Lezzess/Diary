using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Dtos.WeatherForecast;
using MediatR;

namespace Application.Requests.WeatherForecast.Get
{
    public class GetWeatherForecastRequestHandler : IRequestHandler<GetWeatherForecastRequest, List<WeatherForecastDto>>
    {
        #region Constants

        private static readonly string[] Summaries = 
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        #endregion

        #region Public Methods

        public Task<List<WeatherForecastDto>> Handle(GetWeatherForecastRequest request, CancellationToken cancellationToken)
        {
            var rng = new Random();
            var forecasts = Enumerable.Range(1, 5)
                                      .Select(index => new WeatherForecastDto 
                                      { 
                                          Date = DateTime.Now.AddDays(index), 
                                          TemperatureC = rng.Next(-20, 55), 
                                          Summary = Summaries[rng.Next(Summaries.Length)]
                                      })
                                      .ToList();
            return Task.FromResult(forecasts);
        }

        #endregion
    }
}
