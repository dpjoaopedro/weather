using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApi.Models;

namespace WeatherApi.Data
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<Weather>> GetWeather();
    }
}