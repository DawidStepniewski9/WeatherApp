using Newtonsoft.Json;
using System.Buffers.Text;
using WeatherApp.Interfaces;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherAppService : IWeatherAppService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        private string BaseUrl => _configuration["WeatherApi:BaseUrl"];
        private string ApiKey => _configuration["WeatherApi:ApiKey"];
        public WeatherAppService(IConfiguration configuration, HttpClient httpClient) 
        { 
            _configuration = configuration;
            _httpClient = httpClient;
        }
        public async Task<WeatherResponseModel> GetWeatherByCity(string city)
        {
            var weatherLookup = _httpClient.GetAsync(
                $"{BaseUrl}/weather?q={city}&appid={ApiKey}");

            if(!weatherLookup.IsCompletedSuccessfully)
            {
                return null;
            }

            string content = await weatherLookup.Result.Content.ReadAsStringAsync();
            var contentModel = JsonConvert.DeserializeObject<WeatherResponseModel>(content);

            return contentModel;
        }
    }
}
