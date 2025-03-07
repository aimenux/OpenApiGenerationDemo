using ControllerApi.Domain.Models;

namespace ControllerApi.Application.Abstractions;

public interface ITodoRepository
{
    Task<IReadOnlyList<Todo>> GetTodosAsync(string? category, CancellationToken cancellationToken);
}