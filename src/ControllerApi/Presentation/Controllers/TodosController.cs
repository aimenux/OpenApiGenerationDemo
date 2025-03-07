using ControllerApi.Application.Services;
using ControllerApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerApi.Presentation.Controllers;

[ApiController]
[Route(Routes.TodosRoute)]
public class TodosController : ControllerBase
{
    private readonly ITodoService _todoService;

    public TodosController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet(Name = "GetTodos")]
    public async Task<IEnumerable<Todo>> GetTodosAsync([FromQuery] string? category, CancellationToken cancellationToken)
    {
        var todos = await _todoService.GetTodosAsync(category, cancellationToken);
        return todos;
    }
}