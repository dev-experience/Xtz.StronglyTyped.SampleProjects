# Xtz.StronglyTyped.SampleProjects

![GitHub](https://img.shields.io/github/license/dev-experience/Xtz.StronglyTyped.SampleProjects)

Sample projects to show-case [https://github.com/dev-experience/Xtz.StronglyTyped](Xtz.StronglyTyped) libraries.

> **Xtz.StronglyTyped**
>
> ![GitHub](https://img.shields.io/github/license/dev-experience/Xtz.StronglyTyped)
> ![GitHub branch checks state](https://img.shields.io/github/checks-status/dev-experience/Xtz.StronglyTyped/main)
>
> Set of NuGet packages to strongly-type your interfaces (properties, methods, APIs, DB entities, appsettings).
>
> Eliminate stringly-typed interfaces.
>
> Make compiler your friend, introduce semantics to your code.
> 
> | NuGet Package                                  | Version                                                                                                                                                              |
> | ---------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
> | **Xtz.StornglyTyped**                          | [![NuGet](http://img.shields.io/nuget/v/Xtz.StronglyTyped.svg)](https://www.nuget.org/packages/Xtz.StronglyTyped/)                                                   |
> | **Xtz.StronglyTyped.BuiltinTypes**             | [![NuGet](http://img.shields.io/nuget/v/Xtz.StronglyTyped.BuiltinTypes.svg)](https://www.nuget.org/packages/Xtz.StronglyTyped.BuiltinTypes/)                         |
> | **Xtz.StornglyTyped.BuiltinTypes.AutoFixture** | [![NuGet](http://img.shields.io/nuget/v/Xtz.StronglyTyped.BuiltinTypes.AutoFixture.svg)](https://www.nuget.org/packages/Xtz.StronglyTyped.BuiltinTypes.AutoFixture/) |
> | **Xtz.StornglyTyped.BuiltinTypes.Bogus**       | [![NuGet](http://img.shields.io/nuget/v/Xtz.StronglyTyped.BuiltinTypes.Bogus.svg)](https://www.nuget.org/packages/Xtz.StronglyTyped.BuiltinTypes.Bogus/)             |
> | **Xtz.StornglyTyped.EntityFramework**          | [![NuGet](http://img.shields.io/nuget/v/Xtz.StronglyTyped.EntityFramework.svg)](https://www.nuget.org/packages/Xtz.StronglyTyped.EntityFramework/)                   |
> | **Xtz.StronglyTyped.NewtonsoftJson**           | [![NuGet](http://img.shields.io/nuget/v/Xtz.StronglyTyped.NewtonsoftJson.svg)](https://www.nuget.org/packages/Xtz.StronglyTyped.NewtonsoftJson/)                     |
> | **Xtz.StornglyTyped.SourceGenerator**          | [![NuGet](http://img.shields.io/nuget/v/Xtz.StronglyTyped.SourceGenerator.svg)](https://www.nuget.org/packages/Xtz.StronglyTyped.SourceGenerator/)                   |
> | **Xtz.StornglyTyped.Swashbuckle**              | [![NuGet](http://img.shields.io/nuget/v/Xtz.StronglyTyped.Swashbuckle.svg)](https://www.nuget.org/packages/Xtz.StronglyTyped.Swashbuckle/)                           |

## Sample projects

### Web API application (.NET 5.0, System.Text.Json)

Strongly-typed API requests and responses.

[SampleProjects.ApiApp](./src/SampleProjects.ApiApp)

### Web API application (.NET Core 3.1, Newtonsoft.Json)

Strongly-typed API requests and responses.

[SampleProjects.ApiNewtonsoftJsonApp](./src/SampleProjects.ApiNewtonsoftJsonApp)

### Application configuration

Strongly-typed `appsettings.json`.

[SampleProjects.AppSettingApp](./src/SampleProjects.AppSettingsApp)

### AutoFixture unit tests

Auto-populated strongly-typed unit tests parameters powered by `AutoFixture` and custom `Bogus` fakers.

[SampleProjects.AutoDataUnitTests](./src/SampleProjects.AutoDataUnitTests)

### Console app

Console app demo with strongly-typed values.

[SampleProjects.BogusConsoleApp](./src/SampleProjects.BogusConsoleApp)

### Entity Framework Core

Persisting strongly-typed using Entity Framework Core.

[SampleProjects.EntityFrameworkApp](./src/SampleProjects.EntityFrameworkApp)

### Swashbuckle / Swagger

Correcting Open API schema for proper Swagger UI support

[SampleProjects.Example.SwaggerApiApp](./src/SampleProjects.Example.SwaggerApiApp)
