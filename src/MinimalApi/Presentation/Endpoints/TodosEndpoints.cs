using Microsoft.AspNetCore.Mvc;
using MinimalApi.Application.Services;
using MinimalApi.Domain.Models;

namespace MinimalApi.Presentation.Endpoints;

public static class TodosEndpoints
{
    public static IEndpointRouteBuilder MapTodosEndpoints(this IEndpointRouteBuilder app)
    {
        app
            .MapGroup(Routes.TodosRoute)
            .MapGetTodosEndpoint()
            .WithTags("Todos");

        return app;
    }

    private static RouteHandlerBuilder MapGetTodosEndpoint(this IEndpointRouteBuilder app)
    {
        return app
            .MapGet("", async (ITodoService todoService, [FromQuery] string? category, CancellationToken cancellationToken) =>
            {
                var todos = await todoService.GetTodosAsync(category, cancellationToken);
                return Results.Ok(todos);
            })
            .Produces<Todo[]>()
            .WithName("GetTodos");
    }
}