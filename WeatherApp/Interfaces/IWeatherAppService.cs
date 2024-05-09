using WeatherApp.Models;

namespace WeatherApp.Interfaces
{
    public interface IWeatherAppService
    {
        Task<WeatherResponseModel> GetWeatherByCity(string city); 
    }
}
