using System;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClassLibrary
{
    public class WeatherAPI
    {
        public static string cityName, cityTemperature, cityAir, cityWind, cityDescription;
        public static string dayOne;
        public static string[] otherDays = new string[5];
        public static async Task GetWeather(string city)
        {
            var http = new HttpClient();

            var url = $"http://api.openweathermap.org/data/2.5/weather?q=" +
                $"{city}&units=metric&appid=7c37d5d34768e0d00a57859861326938";

            var response = await http.GetAsync(url);

            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);

            WeatherStruct weatherStruct = JsonConvert.DeserializeObject<WeatherStruct>(result);

            cityName = $"{weatherStruct.name}" +
                $" \n{Math.Round(weatherStruct.main["temp"])}°C";

            cityTemperature = $"\nTemperature: {weatherStruct.main["temp"]}°C" +
                $"\nFeels like: {weatherStruct.main["feels_like"]}°C" +
                $"\nMin Temperture: {weatherStruct.main["temp_min"]}°C" +
                $"\nMax Temperature: {weatherStruct.main["temp_max"]}°C";

            cityAir = $"\nPressure: {weatherStruct.main["pressure"]}hPa" +
                $"\nHumidity: {weatherStruct.main["humidity"]}%";

            cityWind = $"\nWind speed: {weatherStruct.wind["speed"]}m/s" +
                $"\nWind degree direction: {weatherStruct.wind["deg"]}°";

            cityDescription = $"\n{weatherStruct.weather.Rows[0]["main"]}" +
                $" - {weatherStruct.weather.Rows[0]["description"]}";

            return;
        }

        public static async Task GetForecast(string city)
        {
            var http = new HttpClient();

            // Get latitude and longitude from city name
            var geocodeUrl = $"http://api.openweathermap.org/geo/1.0/direct?q={city}&limit=1&appid=7c37d5d34768e0d00a57859861326938";
            var geocodeResponse = await http.GetAsync(geocodeUrl);
            var geocodeResult = await geocodeResponse.Content.ReadAsStringAsync();
            
            // Strip the [] brackets
            geocodeResult = geocodeResult.Substring(1, geocodeResult.Length - 2);

            // Get lat and lon with the structure
            GeocodeStructure geocodeStructure = JsonConvert.DeserializeObject<GeocodeStructure>(geocodeResult);

            var url = $"https://api.openweathermap.org/data/2.5/forecast?" +
                $"lat={geocodeStructure.lat}&lon={geocodeStructure.lon}&units=metric" +
                $"&appid=7c37d5d34768e0d00a57859861326938";

            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();

            // Extract the needed data from the string (JSON)
            ForecastStructure forecastStructure = JsonConvert.DeserializeObject<ForecastStructure>(result);

            dayOne = "Today\n" + forecastStructure.list[0]["main"]["temp"] + "°C";
            var j = 0;

            var temporary = DateTime.Now;
            for (int i = 0; i < forecastStructure.list.Count; i++)
            {
                var test = DateTime.Parse((string)forecastStructure.list[i]["dt_txt"]);

                // Will give us only noon forecasts, we don't want midnight forecast
                if (test.Hour == 12)
                {
                    if (test.Date > temporary.Date)
                    {
                        otherDays[j] = test.Date.ToString() + "\n" + forecastStructure.list[i]["main"]["temp"] + "°C";
                        j++;

                        temporary = temporary.AddDays(1);
                    }
                }
                
                
            }
            
                
            

            return;
        }
    }
}
