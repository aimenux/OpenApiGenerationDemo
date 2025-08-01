using Scalar.AspNetCore;

namespace Presentation.Extensions;

public static class OpenApiExtensions
{
    public static void AddOpenApi(this WebApplicationBuilder builder)
    {
        foreach (var version in Constants.Api.Versions)
        {
            builder.Services.AddOpenApi(version);
        }
    }

    public static void UseOpenApi(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            return;
        }

        app
            .MapOpenApi()
            .CacheOutput(Constants.Policies.OpenApiCachePolicy);

        app.MapScalarApiReference();
    }
}