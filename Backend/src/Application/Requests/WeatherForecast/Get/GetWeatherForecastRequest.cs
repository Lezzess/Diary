using System.Collections.Generic;
using Application.Dtos.WeatherForecast;
using MediatR;

namespace Application.Requests.WeatherForecast.Get
{
    public class GetWeatherForecastRequest : IRequest<List<WeatherForecastDto>>
    {
        // Empty
    }
}
