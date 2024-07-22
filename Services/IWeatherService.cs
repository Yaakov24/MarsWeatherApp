using System.Threading.Tasks;
using MarsWeatherApp.Models;

namespace MarsWeatherApp.Services
{
    public interface IWeatherService
    {
        Task<WeatherData> GetWeatherDataAsync();
    }
}
