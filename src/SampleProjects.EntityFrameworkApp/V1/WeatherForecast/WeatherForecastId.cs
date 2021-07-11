using System;
using Xtz.StronglyTyped.BuiltinTypes.Ids;
using Xtz.StronglyTyped.SourceGenerator;

namespace SampleProjects.EntityFrameworkApp.V1.WeatherForecast
{
    // NOTE: Strong type (class) based on `Guid`
    // NOTE: `StrongTypeAttribute` triggers source generation on compilation. All strongly-typed functionality is generated in a partial class
    // NOTE: `GuidId` is a base class for GUID-based IDs that comes from `Xtz.StronglyTyped.BuiltinTypes` package
    [StrongType(typeof(Guid))]
    public partial class WeatherForecastId : GuidId
    {
    }
}