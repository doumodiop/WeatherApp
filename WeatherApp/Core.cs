using System;
using System.Threading.Tasks;
namespace WeatherApp
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {
            string key = "eeb78057a7e367d03481fdae4acb10c6";

			string queryString = "http://api.openweathermap.org/data/2.5/weather?zip=" + zipCode + ",us&appid=" + key + "&units=imperial";

			
            dynamic results = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            Weather weather = null;
            if (results["weather"] != null)
            {


                weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                weather.Wind = (string)results["wind"]["speed"] + "mph";
                weather.Humidity = (string)results["main"]["humidity"];
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);

                weather.Sunset = sunset.ToString() + " UTC";
                weather.Sunrise = sunrise.ToString() + " UTC";

            }
           


            return weather;
		}
    }
}
