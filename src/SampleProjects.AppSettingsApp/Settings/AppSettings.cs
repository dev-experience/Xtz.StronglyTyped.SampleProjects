using SampleProjects.AppSettingsApp.Models;
using Xtz.StronglyTyped.BuiltinTypes.Address;
using Xtz.StronglyTyped.BuiltinTypes.Internet;

namespace SampleProjects.AppSettingsApp.Settings
{
    public class AppSettings
    {
        public City City { get; set; }

        public SchemaId SchemaId { get; set; }

        public Email AdministratorEmail { get; set; }

        public InstanceId InstanceId { get; set; }
    }
}
