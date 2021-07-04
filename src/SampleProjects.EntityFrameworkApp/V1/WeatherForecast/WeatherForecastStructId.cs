using System;
using Xtz.StronglyTyped;

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

        public WeatherForecastStructId(string value)
            : this(Guid.Parse(value))
        {
        }

        public static explicit operator WeatherForecastStructId(string value)
        {
            return new WeatherForecastStructId(value);
        }

        public static implicit operator string(WeatherForecastStructId stronglyTyped)
        {
            return stronglyTyped.ToString();
        }
    }
}