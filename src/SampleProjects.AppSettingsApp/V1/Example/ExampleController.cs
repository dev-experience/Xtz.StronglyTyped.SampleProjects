using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SampleProjects.AppSettingsApp.Settings;

namespace SampleProjects.AppSettingsApp.V1.Example
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ExampleController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;

        private readonly ILogger<ExampleController> _logger;

        public ExampleController(
            IOptions<AppSettings> appSettings,
            ILogger<ExampleController> logger)
        {
            _appSettings = appSettings;
            _logger = logger;

            _logger.LogInformation($"{nameof(AppSettings)}:\nCity = {_appSettings.Value.City}\nSchemaId = {_appSettings.Value.SchemaId}\nAdministratorEmail = {_appSettings.Value.AdministratorEmail}\nInstanceId = {_appSettings.Value.InstanceId}");
        }

        [HttpGet]
        public AppSettings Get()
        {
            // NOTE: Responding with current `AppSettings` just to show current strongly-typed settings (for demo purposes only; not a usual use case)
            return _appSettings.Value;
        }
    }
}
