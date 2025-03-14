﻿using MinimalApi.Application.Abstractions;
using MinimalApi.Domain.Models;

namespace MinimalApi.Application.Services;

public sealed class TodoService : ITodoService
{
    private readonly ITodoRepository _todoRepository;

    public TodoService(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<IReadOnlyList<Todo>> GetTodosAsync(string? category, CancellationToken cancellationToken)
    {
        var todos = await _todoRepository.GetTodosAsync(category, cancellationToken);
        return todos;
    }
}