using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SampleProjects.EntityFrameworkApp.Data;

namespace SampleProjects.EntityFrameworkApp.V1.WeatherForecast
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public WeatherForecastController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IQueryable<WeatherForecast> Get()
        {
            var result = _dbContext.WeatherForecasts;
            return result;
        }
    }
}
