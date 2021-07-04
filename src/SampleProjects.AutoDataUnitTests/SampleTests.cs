using NUnit.Framework;
using Xtz.StronglyTyped.BuiltinTypes.AutoFixture;
using Xtz.StronglyTyped.BuiltinTypes.Company;

namespace SampleProjects.AutoDataUnitTests
{
    public class SampleTests
    {
        [Test]
        // NOTE: Use `StrongAutoDataAttribute` to auto-inject arguments
        [StrongAutoData]
        public void CompanyNameTest(
            // NOTE: Argument is auto-populated by `AutoFixture` using respective custom Bogus faker from `Xtz.StronglyTyped.BuiltinTypes.AutoFixture` package
            CompanyName companyName)
        {
            // Act

            // Implicit conversion test from `CompanyName` to `string` (for demo purposes only; it's not the main focus of the sample project)
            string companyNameString = companyName;


            // Assert

            Assert.AreEqual(companyName.Value, companyNameString);
        }
    }
}