using MinimalApi.Domain.Models;

namespace MinimalApi.Application.Services;

public interface ITodoService
{
    Task<IReadOnlyList<Todo>> GetTodosAsync(string? category, CancellationToken cancellationToken);
}