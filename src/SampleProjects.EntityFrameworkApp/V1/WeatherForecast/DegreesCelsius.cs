using Xtz.StronglyTyped;

namespace SampleProjects.EntityFrameworkApp.V1.WeatherForecast
{
    // NOTE: Strong type based on `int`
    // NOTE: `StrongTypeAttribute` triggers source generation on compilation. All strongly-typed functionality is generated in a partial class
    [StrongType(typeof(int))]
    public partial class DegreesCelsius
    {
    }
}