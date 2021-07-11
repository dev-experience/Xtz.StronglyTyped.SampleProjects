using System;
using Xtz.StronglyTyped.BuiltinTypes.Ids;
using Xtz.StronglyTyped.SourceGenerator;

namespace SampleProjects.AppSettingsApp.Models
{
    [StrongType(typeof(Guid))]
    public partial class InstanceId : GuidId
    {
    }
}
