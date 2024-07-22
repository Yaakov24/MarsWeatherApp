using System.Net.Http;
using System.Threading.Tasks;
using MarsWeatherApp.Models;
using Newtonsoft.Json;

namespace MarsWeatherApp.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherData> GetWeatherDataAsync()
        {
            var response = await _httpClient.GetStringAsync("https://api.example.com/marsweather");
            return JsonConvert.DeserializeObject<WeatherData>(response);
        }
    }
}
