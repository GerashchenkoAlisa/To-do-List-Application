
// <copyright file="TodoListDbContext.cs" company="TodoListApp">
// Copyright (c) TodoListApp. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Models;

namespace TodoListApp.WebApi.Data;

/// <summary>
/// Represents the database context for the To-Do list.
/// </summary>
public class TodoListDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TodoListDbContext"/> class.
    /// </summary>
    /// <param name="options">The database context options.</param>
    public TodoListDbContext(DbContextOptions<TodoListDbContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets or sets the collection of To-Do items.
    /// </summary>
    public DbSet<TodoItem> TodoItems { get; set; }

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TodoItem>().HasData(
            new TodoItem
            {
                Id = 1,
                Title = "Complete project setup",
                Description = "Configure the solution and projects",
                IsCompleted = true,
            },
            new TodoItem
            {
                Id = 2,
                Title = "Implement Web API",
                Description = "Create CRUD endpoints for todo items",
                IsCompleted = false,
            },
            new TodoItem
            {
                Id = 3,
                Title = "Write unit tests",
                Description = "Add tests for application functionality",
                IsCompleted = false,
            });
    }
}
