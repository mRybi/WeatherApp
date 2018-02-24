using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.OpenWeatherMap.models;

namespace WeatherApp.OpenWeatherMap
{
    public class GetData
    {
        private readonly HttpClient _client;
        private static readonly string API_KEY = "5e272dc7c708384cafcf594a2e43bde8";

        public GetData()
        {
            _client = new HttpClient();
        }

        public async Task<WheaterFromJSON> GetForecastForCity(string city)
        {
            var response =await _client.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={city}&APPID={API_KEY}");
            //response.EnsureSuccessStatusCode();
            
            var responseString =await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<WheaterFromJSON>(responseString);
            if (response.StatusCode == HttpStatusCode.OK)
                return data;
            else
                return null;
        }
    }
}
