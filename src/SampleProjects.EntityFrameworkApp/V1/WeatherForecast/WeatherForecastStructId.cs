using System;
using Xtz.StronglyTyped.SourceGenerator;

namespace SampleProjects.EntityFrameworkApp.V1.WeatherForecast
{
    // NOTE: Strong type (struct) based on `Guid`
    // NOTE: `StrongTypeAttribute` triggers source generation on compilation. All strongly-typed functionality is generated in a partial class
    [StrongType(typeof(Guid))]
    public partial struct WeatherForecastStructId
    {
        public static WeatherForecastStructId New()
        {
            return new WeatherForecastStructId(Guid.NewGuid());
        }
    }
}