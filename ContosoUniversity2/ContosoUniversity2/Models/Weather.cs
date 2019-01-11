using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ContosoUniversity2.Models
{
    
    public class Weather
    {
        [DisplayName("温度")]
        public string Temperature { get; set; }

        [DisplayName("城市")]
        public string City { get; set; }

        public string WeatherInfo { get; set; }
        public string Wind_strength { get; set; }
        [DisplayName("湿度")]
        public string Humidity { get; set; }
    }
}