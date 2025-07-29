using Application.Abstractions;
using Domain.Models;

namespace Infrastructure.Repositories;

public sealed class TodoRepository : ITodoRepository
{
    public Task<IReadOnlyList<Todo>> GetTodosAsync(string? category, CancellationToken cancellationToken)
    {
        var todos = Enumerable.Range(1, RandomNumber())
            .Select(_ => GetTodo(category))
            .ToList();

        return Task.FromResult<IReadOnlyList<Todo>>(todos);
    }

    private static Todo GetTodo(string? category)
    {
        return new Todo
        {
            Title = Guid.NewGuid().ToString("N"),
            Category = category,
            IsCompleted = RandomNumber() % 2 == 0,
            CreationDate = DateTime.Now.AddDays(-RandomNumber())
        };
    }

    private static int RandomNumber(int min = 1, int max = 100)
    {
        return Random.Shared.Next(min, max);
    }
}