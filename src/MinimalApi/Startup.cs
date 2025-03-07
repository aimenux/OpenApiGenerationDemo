using MinimalApi.Application;
using MinimalApi.Infrastructure;
using MinimalApi.Presentation;
using MinimalApi.Presentation.Endpoints;
using MinimalApi.Presentation.Extensions;

namespace MinimalApi;

public class Startup
{
    public void ConfigureServices(WebApplicationBuilder builder)
    {
        builder
            .AddPresentation()
            .AddApplication()
            .AddInfrastructure();
    }

    public void Configure(WebApplication app)
    {
        app.UseHttpLogging();
        app.UseOutputCache();
        app.UseOpenApi();
        app.UseHttpsRedirection();
        app.MapTodosEndpoints();
    }
}