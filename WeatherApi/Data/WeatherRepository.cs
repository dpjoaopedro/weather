using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeatherApi.Models;

namespace WeatherApi.Data
{
    public class WeatherRepository : IWeatherRepository
    {
        private DataContext _context;

        public WeatherRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Weather>> GetWeather()
        {
            return await _context.Weathers.ToListAsync();
        }
    }
}