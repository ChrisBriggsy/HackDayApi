using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HackDayAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WeatherController : ApiController
    {
        private static List<WeatherData> _weatherData = new List<WeatherData>();
        
        public List<WeatherData> Get()
        {
            return _weatherData;
        }

        public void Post([FromBody]WeatherData value)
        {
            _weatherData.Add(value);
        }

        public void Delete()
        {
            _weatherData = new List<WeatherData>();
        }
    }

    public class WeatherData
    {
        public string DeviceID { get; set; }
        public float Humidity { get; set; }
        public float Temperature { get; set; }
    }
}
