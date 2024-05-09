namespace WeatherApp.Models
{
    public class WeatherResponseModel
    {
        public Weather Weather { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
    }

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
        public int Sea_level { get; set; }
        public int Grnd_level { get; set; }
    }
    public class Wind()
    {
        public double Speed { get; set; }
        public int Deg {  get; set; }
        public double Gust { get; set; }
    }
}
