using ControllerApi.Application.Services;

namespace ControllerApi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<ITodoService, TodoService>();
        return services;
    }
}