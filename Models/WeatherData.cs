namespace MarsWeatherApp.Models
{
    public class WeatherData
    {
        public float Temperature { get; set; }

        public WeatherData(float _temp)
        {
            Temperature = _temp;
        }
    }
}
