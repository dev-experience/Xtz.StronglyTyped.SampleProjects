using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Xtz.StronglyTyped.BuiltinTypes.Address;

namespace SampleProjects.ApiNewtonsoftJsonApp.V1.WeatherForecast
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly Random RANDOM = new();

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5)
                .Select(index => BuildWeatherForecast(index))
                .ToArray();
        }

        private static WeatherForecast BuildWeatherForecast(int index)
        {
            // NOTE: You can use a `City` constructor
            var city = new City("Amsterdam");
            var date = DateTime.Now.AddDays(index);
            // NOTE: You can cast to `DegreesCelsius` explicitly
            var degreesCelsius = (DegreesCelsius)RANDOM.Next(-20, 55);
            var summary = Summaries[RANDOM.Next(Summaries.Length)];

            var result = new WeatherForecast(city, date, degreesCelsius, summary);
            return result;
        }
    }
}
