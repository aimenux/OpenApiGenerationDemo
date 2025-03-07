using ControllerApi.Domain.Models;

namespace ControllerApi.Application.Services;

public interface ITodoService
{
    Task<IReadOnlyList<Todo>> GetTodosAsync(string? category, CancellationToken cancellationToken);
}