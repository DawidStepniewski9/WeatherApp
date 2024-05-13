using Microsoft.AspNetCore.Mvc;
using WeatherApp.Interfaces;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class WeatherAppController : ControllerBase
    {
        private readonly IWeatherAppService _service;

        public WeatherAppController(IWeatherAppService service)
        {
            _service = service;
        }

        [HttpGet("/GetWeather")]
        public async Task<IActionResult> GetWeather(GettingWeatherModel model)
        { 
            var result = await _service.GetWeatherByCity(model.City);
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
