using Domain.Models;

namespace Application.Services;

public interface ITodoService
{
    Task<IReadOnlyList<Todo>> GetTodosAsync(string? category, CancellationToken cancellationToken);
}