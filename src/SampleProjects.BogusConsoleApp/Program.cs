using System;
using System.Linq;
using System.Text.Json;
using SampleProjects.BogusConsoleApp.Models;
using Xtz.StronglyTyped.BuiltinTypes.Bogus;

namespace SampleProjects.BogusConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: Generating 100 fake company models
            var companyModels = Enumerable.Range(1, 100)
                .Select(x => BuildCompanyModel())
                .ToArray();

            // NOTE: Serializing the array and printing it to the console
            Console.WriteLine(JsonSerializer.Serialize(companyModels, new JsonSerializerOptions{ WriteIndented = true }));
        }

        private static CompanyModel BuildCompanyModel()
        {
            var companyAddress = BuildCompanyAddress();
            var companyAccount = BuildCompanyAccount();

            // NOTE: Builder creates a custom Bogus fakers that generate test data
            var builder = new CompanyFakerBuilder(true);
            var faker = builder.BuildEnterpriseNameFaker();
            var enterpriseName = faker.Generate();

            var result = new CompanyModel(enterpriseName, companyAddress, companyAccount);
            return result;
        }

        private static CompanyAddress BuildCompanyAddress()
        {
            // NOTE: Builder creates a custom Bogus fakers that generate test data
            var builder = new AddressFakerBuilder(true);

            var streetAddress = builder.BuildStreetAddressFaker(true).Generate();
            var city = builder.BuildCityFaker().Generate();
            var country = builder.BuildCountryFaker().Generate();
            var zipCode = builder.BuildPostalCodeFaker().Generate();

            var result = new CompanyAddress(streetAddress, city, country, zipCode);
            return result;
        }

        private static CompanyAccount BuildCompanyAccount()
        {
            var builder = new FinanceFakerBuilder(true);

            var accountNumber = builder.BuildAccountNumberFaker().Generate();
            var bic = builder.BuildBicFaker().Generate();
            var iban = builder.BuildIbanFaker().Generate();
            var routingNumber = builder.BuildRoutingNumberFaker().Generate();

            var result = new CompanyAccount(accountNumber, bic, iban, routingNumber);
            return result;
        }
    }
}
