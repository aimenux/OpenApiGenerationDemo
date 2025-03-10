﻿using System.Text.Json;
using System.Text.Json.Serialization;
using ControllerApi.Presentation.Extensions;
using Microsoft.AspNetCore.HttpLogging;

namespace ControllerApi.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this WebApplicationBuilder builder)
    {
        var services = builder.Services;
        builder.AddControllers();
        builder.AddHttpLogging();
        builder.AddOpenApi();
        builder.AddRouteOptions();
        builder.AddOutputCache();
        return services;
    }

    private static void AddControllers(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            });
    }

    private static void AddHttpLogging(this WebApplicationBuilder builder)
    {
        builder.Services.AddHttpLogging(logging =>
        {
            logging.LoggingFields = HttpLoggingFields.All;
            logging.CombineLogs = true;
        });
    }

    private static void AddRouteOptions(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<RouteOptions>(options =>
        {
            options.LowercaseUrls = true;
            options.LowercaseQueryStrings = true;
        });
    }

    private static void AddOutputCache(this WebApplicationBuilder builder)
    {
        builder.Services.AddOutputCache(options =>
        {
            options.AddPolicy(Constants.Policies.OpenApiCachePolicy, policy =>
            {
                policy.Expire(TimeSpan.FromMinutes(5)).Cache();
            });
        });
    }
}