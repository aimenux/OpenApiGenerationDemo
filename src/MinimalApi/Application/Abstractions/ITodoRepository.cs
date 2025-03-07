using MinimalApi.Domain.Models;

namespace MinimalApi.Application.Abstractions;

public interface ITodoRepository
{
    Task<IReadOnlyList<Todo>> GetTodosAsync(string? category, CancellationToken cancellationToken);
}