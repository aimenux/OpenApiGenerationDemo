using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Endpoints;

public static class TodosEndpoints
{
    public static IEndpointRouteBuilder MapTodosEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app
            .MapGroup(Constants.Routes.TodosRoute)
            .WithName("TodosEndpoints")
            .WithTags("Todos")
            .WithOpenApi();

        group
            .MapGet("", async (ITodoService todoService, [FromQuery] string? category, CancellationToken cancellationToken) =>
            {
                var todos = await todoService.GetTodosAsync(category, cancellationToken);
                return Results.Ok(todos);
            })
            .WithName("GetTodos")
            .WithSummary("Retrieves a list of todos")
            .WithDescription("Gets all todos, optionally filtered by category")
            .Produces<IEnumerable<Todo>>(contentType: "application/json");

        return app;
    }
}