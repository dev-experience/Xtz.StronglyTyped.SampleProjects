using System;
using Xtz.StronglyTyped.BuiltinTypes.Address;
using Xtz.StronglyTyped.BuiltinTypes.Internet;

namespace SampleProjects.EntityFrameworkApp.V1.WeatherForecast
{
    public class WeatherForecast
    {
        // NOTE: `WeatherForecastId` (class) is generated in current project
        public WeatherForecastId Id { get; set; }

        // NOTE: `WeatherForecastStructId` (struct) is generated in current project
        public WeatherForecastStructId StructId { get; set; }

        // NOTE: `City` type comes from `Xtz.StronglyTyped.BuiltinTypes` package
        public City City { get; set; }

        // NOTE: `Email` type comes from `Xtz.StronglyTyped.BuiltinTypes` package
        public Email Email { get; set; }

        public DateTime Date { get; set; }

        // NOTE: `DegreesCelsius` (class) is generated in current project
        public DegreesCelsius TemperatureC { get; set; }

        public string Summary { get; set; }
    }
}
