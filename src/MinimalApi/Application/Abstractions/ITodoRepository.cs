using Domain.Models;

namespace Application.Abstractions;

public interface ITodoRepository
{
    Task<IReadOnlyList<Todo>> GetTodosAsync(string? category, CancellationToken cancellationToken);
}