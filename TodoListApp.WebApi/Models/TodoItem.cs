// <copyright file="TodoItem.cs" company="TodoListApp">
// Copyright (c) TodoListApp. All rights reserved.
// </copyright>

namespace TodoListApp.WebApi.Models;

/// <summary>
/// Represents a task in the To-Do list.
/// </summary>
public class TodoItem
{
    /// <summary>
    /// Gets or sets the task identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the task title.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the task description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the task is completed.
    /// </summary>
    public bool IsCompleted { get; set; }
}