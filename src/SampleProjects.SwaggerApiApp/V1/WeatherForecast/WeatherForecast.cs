using System;
using Xtz.StronglyTyped.BuiltinTypes.Address;
using Xtz.StronglyTyped.BuiltinTypes.Internet;

namespace SampleProjects.Example.SwaggerApiApp.V1.WeatherForecast
{
    // NOTE: `City` type comes from `Xtz.StronglyTyped.BuiltinTypes` package
    // NOTE: `DegreesCelsius` is generated in current project
    // NOTE: `IsCold` is generated in current project
    // NOTE: `RelativeUri` type comes from `Xtz.StronglyTyped.BuiltinTypes` package
    public record WeatherForecast(City City, DateTime Date, DegreesCelsius TemperatureC, string Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public IsCold IsCold => new IsCold(TemperatureC.Value < 15);

        public RelativeUri RelativeUri => new RelativeUri("api/v1/WeatherForecast");
    }
}
