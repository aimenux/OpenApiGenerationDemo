using Application;
using Infrastructure;
using Presentation.Endpoints;
using Presentation.Extensions;

namespace Presentation;

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