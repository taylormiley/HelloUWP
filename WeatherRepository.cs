using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace HelloUWP
{
    public static class WeatherRepository
    {
        private static WeatherModel weatherCache;

        public static async Task<WeatherModel> GetCurrentWeatherAsync()
        {
            if (weatherCache != null)
                return weatherCache;
            var client = new HttpClient();
            var stream = await client.GetStreamAsync(
                "api.openweathermap.org/data/2.5/weather?zip=37075,us&appid=5e662da7c96732e96d9a40fd99685210");

            var serializer = new DataContractJsonSerializer(typeof(WeatherModel));
            weatherCache = (WeatherModel)serializer.ReadObject(stream);

            return weatherCache;
        }
    }
}
