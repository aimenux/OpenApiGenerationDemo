using ControllerApi.Application.Services;
using ControllerApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerApi.Presentation.Controllers;

[ApiController]
[Route(Constants.Routes.TodosRoute)]
public class TodosController : ControllerBase
{
    private readonly ITodoService _todoService;

    public TodosController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [Tags("todos")]
    [EndpointName("GetTodos")]
    [EndpointSummary("Retrieves a list of todos")]
    [EndpointDescription("Gets all todos, optionally filtered by category")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Todo>), StatusCodes.Status200OK)]
    [HttpGet(Name = "GetTodos")]
    public async Task<IEnumerable<Todo>> GetTodosAsync([FromQuery] string? category, CancellationToken cancellationToken)
    {
        var todos = await _todoService.GetTodosAsync(category, cancellationToken);
        return todos;
    }
}