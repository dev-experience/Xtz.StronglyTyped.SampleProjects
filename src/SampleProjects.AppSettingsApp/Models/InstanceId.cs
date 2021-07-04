using System;
using System.ComponentModel;
using Xtz.StronglyTyped.BuiltinTypes.Ids;
using Xtz.StronglyTyped.TypeConverters;

namespace SampleProjects.AppSettingsApp.Models
{
    [TypeConverter(typeof(TypeConverter<InstanceId, Guid>))]
    public sealed class InstanceId : GuidId
    {
        public InstanceId(Guid value)
            : base(value)
        {
        }

        public InstanceId()
        {
        }
    }
}
