using ControllerApi.Application.Abstractions;
using ControllerApi.Infrastructure.Repositories;

namespace ControllerApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<ITodoRepository, TodoRepository>();
        return services;
    }
}