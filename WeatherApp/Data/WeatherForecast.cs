using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Data
{
    public class WeatherForecast
        {
            public DayForcast[] weatherForecast { get; set; }
            public DateTime Time { get; set; }
            public DateTime Sun_rise { get; set; }
            public DateTime Sun_set { get; set; }
            public string Timezone_name { get; set; }
            public string Title { get; set; }
            public string Timezone { get; set; }
        }
    
}
