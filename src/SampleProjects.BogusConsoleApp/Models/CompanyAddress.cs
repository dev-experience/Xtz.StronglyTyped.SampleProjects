using Xtz.StronglyTyped.BuiltinTypes.Address;

namespace SampleProjects.BogusConsoleApp.Models
{
    public record CompanyAddress(StreetAddress StreetAddress, City City, Country Country, PostalCode PostalCode);
}