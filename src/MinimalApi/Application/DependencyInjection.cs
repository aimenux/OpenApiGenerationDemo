using MinimalApi.Application.Services;

namespace MinimalApi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<ITodoService, TodoService>();
        return services;
    }
}