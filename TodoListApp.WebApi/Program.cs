// <copyright file="Program.cs" company="TodoListApp">
// Copyright (c) TodoListApp. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Get connection string from appsettings.json.
var connectionString = builder.Configuration.GetConnectionString("TodoListConnection")
    ?? throw new InvalidOperationException("Connection string not found.");

// Register the connection to SQL Server.
builder.Services.AddDbContext<TodoListDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();