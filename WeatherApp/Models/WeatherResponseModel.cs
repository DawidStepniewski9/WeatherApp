using Newtonsoft.Json;
namespace WeatherApp.Models
{
    public class WeatherResponseModel
    {
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
    }

    //"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"},{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],
    public class Weather()
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Main()
    {
        public double Temp { get; set; }
        public double Feels_like { get; set; }
        public double Temp_min { get; set; }
        public double Temp_max { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }
    public class Wind()
    {
        public double Speed { get; set; }
        public int Deg {  get; set; }
    }
}
