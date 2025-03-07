using MinimalApi.Application.Abstractions;
using MinimalApi.Infrastructure.Repositories;

namespace MinimalApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<ITodoRepository, TodoRepository>();
        return services;
    }
}