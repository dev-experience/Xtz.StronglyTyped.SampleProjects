using System;
using Xtz.StronglyTyped.BuiltinTypes.Address;

namespace SampleProjects.ApiApp.V1.WeatherForecast
{
    // NOTE: `City` type comes from `Xtz.StronglyTyped.BuiltinTypes` package
    // NOTE: `DegreesCelsius` is generated in current project
    public record WeatherForecast(City City, DateTime Date, DegreesCelsius TemperatureC, string Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
