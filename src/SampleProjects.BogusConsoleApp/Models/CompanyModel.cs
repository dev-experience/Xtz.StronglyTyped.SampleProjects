using Xtz.StronglyTyped.BuiltinTypes.Company;

namespace SampleProjects.BogusConsoleApp.Models
{
    public record CompanyModel(EnterpriseName Name, CompanyAddress Address, CompanyAccount Account);
}