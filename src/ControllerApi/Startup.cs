using ControllerApi.Application;
using ControllerApi.Infrastructure;
using ControllerApi.Presentation;
using ControllerApi.Presentation.Extensions;

namespace ControllerApi;

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
        app.UseOpenApi();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
    }
}