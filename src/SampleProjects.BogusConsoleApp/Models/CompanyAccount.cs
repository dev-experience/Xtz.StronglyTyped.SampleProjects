using Xtz.StronglyTyped.BuiltinTypes.Finance;

namespace SampleProjects.BogusConsoleApp.Models
{
    public record CompanyAccount(AccountNumber AccountNumber, Bic Bic, Iban Iban, RoutingNumber RoutingNumber);
}