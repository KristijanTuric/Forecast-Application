using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClassLibrary
{
    public class WeatherAPI
    {
        public static string cityName, cityTemperature, cityAir, cityWind, 
            cityDescription;
        public static async Task GetWeather(string city)
        {
            var http = new HttpClient();
            var url = $"http://api.openweathermap.org/data/2.5/weather?q=" +
                $"{city}&units=metric&appid=7c37d5d34768e0d00a57859861326938";
            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            WeatherStruct weatherStruct = JsonConvert.DeserializeObject
                <WeatherStruct>(result);

            cityName = $"{weatherStruct.name}" +
                $" {Math.Round(weatherStruct.main["temp"])}°C";
            cityTemperature = $"\nTemperature: {weatherStruct.main["temp"]}°C" +
                $"\nFeels like: {weatherStruct.main["feels_like"]}°C" +
                $"\nMin Temperture: {weatherStruct.main["temp_min"]}°C" +
                $"\nMax Temperature: {weatherStruct.main["temp_max"]}°C";
            cityAir = $"\nPressure: {weatherStruct.main["pressure"]}hPa" +
                $"\nHumidity: {weatherStruct.main["humidity"]}%";
            cityWind = $"\nWind speed: {weatherStruct.wind["speed"]}m/s" +
                $"\nWind degree direction: {weatherStruct.wind["deg"]}°";
            cityDescription = $"\nDescription: " +
                $"{weatherStruct.weather.Rows[0]["main"]}" +
                $" - {weatherStruct.weather.Rows[0]["description"]}";

            return;
        }
    }
}
