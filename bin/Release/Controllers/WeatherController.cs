using MarsWeatherApp.Models;
using MarsWeatherApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarsWeatherApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("info")]
        public IActionResult GetInfo()
        {
            return Ok(new { message = "https://mars.nasa.gov/msl/weather/" });
        }

        [HttpGet("weather")]
        public async Task<IActionResult> GetWeather()
        {
            var weatherData = await _weatherService.GetWeatherDataAsync();
            return Ok(new { TemperatureFahrenheit = (weatherData.Atmo_temp * 9 / 5) + 32 });
        }
    }
}