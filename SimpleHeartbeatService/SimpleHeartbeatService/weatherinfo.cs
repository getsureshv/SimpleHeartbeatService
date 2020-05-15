using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHeartbeatService
{

    public class Weatherinfo
    {
        public List<weather> weather { get; set; }
        public main main { get; set; }
    }

    public class main
    {
        public double temp { get; set; }
    }
    public class weather
    {
        public string main { get; set; }
        public string description { get; set; }
    }
}
// Json Sample of output , need to parse, Temprature , and Main of weather
//{
//  "coord": {
//    "lon": -96.78,
//    "lat": 32.77
//  },
//  "weather": [
//    {
//      "id": 800,
//      "main": "Clear",
//      "description": "clear sky",
//      "icon": "01n"
//    }
//  ],
//  "base": "stations",
//  "main": {
//    "temp": 75.67,
//    "feels_like": 73.94,
//    "temp_min": 73.99,
//    "temp_max": 78.8,
//    "pressure": 1010,
//    "humidity": 74
//  },
//  "visibility": 16093,
//  "wind": {
//    "speed": 13.87,
//    "deg": 150,
//    "gust": 23.04
//  },
//  "clouds": {
//    "all": 1
//  },
//  "dt": 1589518938,
//  "sys": {
//    "type": 1,
//    "id": 5625,
//    "country": "US",
//    "sunrise": 1589542077,
//    "sunset": 1589591952
//  },
//  "timezone": -18000,
//  "id": 4684904,
//  "name": "Dallas",
//  "cod": 200
//}