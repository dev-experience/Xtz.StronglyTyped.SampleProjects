using System;
using System.Linq;
using SampleProjects.EntityFrameworkApp.V1.WeatherForecast;
using Xtz.StronglyTyped.BuiltinTypes.Address;
using Xtz.StronglyTyped.BuiltinTypes.Internet;

namespace SampleProjects.EntityFrameworkApp.Data
{
    // NOTE: `DbInitializer` is only for demo purposes. It's not required to have any
    internal class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.WeatherForecasts.Any())
            {
                return;
            }

            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
            
            var rng = new Random();
            var entities = Enumerable.Range(1, 5)
                .Select(index =>
                {
                    var city = new City("Amsterdam");
                    return new WeatherForecast
                    {
                        // NOTE: Calling `WeatherForecastId` (class) constructor without parameter will create a random Guid
                        Id = new WeatherForecastId(),
                        // NOTE: `WeatherForecastStructId` is a struct, calling empty constructor would initialize all properties with default values
                        // NOTE: To create a new Guid we call custom static method `WeatherForecastStructId.New()`
                        StructId = WeatherForecastStructId.New(),
                        City = city,
                        Email = new Email("bob@example.com"),
                        Date = DateTime.Now.AddDays(index),
                        // NOTE: You can cast to `DegreesCelsius` explicitly
                        TemperatureC = (DegreesCelsius)rng.Next(-20, 55),
                        Summary = summaries[rng.Next(summaries.Length)]
                    };
                })
                .ToArray();

            context.WeatherForecasts.AddRange(entities);
            context.SaveChanges();
        }
    }
}