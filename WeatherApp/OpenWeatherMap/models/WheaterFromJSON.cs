using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.OpenWeatherMap.models
{
    public class WheaterFromJSON
    {
        public Coord Coord { get; set; }
        public IEnumerable<Weather> Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }
}
