using Scalar.AspNetCore;

namespace ControllerApi.Presentation.Extensions;

public static class OpenApiExtensions
{
    public static void AddOpenApi(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApi();
    }

    public static void UseOpenApi(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            return;
        }

        app.MapOpenApi();
        app.MapScalarApiReference();
    }
}