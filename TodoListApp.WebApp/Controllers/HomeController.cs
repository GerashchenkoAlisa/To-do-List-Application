// <copyright file="HomeController.cs" company="TodoListApp">
// Copyright (c) TodoListApp. All rights reserved.
// </copyright>

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApp.Models;

namespace TodoListApp.WebApp.Controllers;

[System.Diagnostics.CodeAnalysis.SuppressMessage(
    "Performance",
    "CA1515:Consider making public types internal",
    Justification = "ASP.NET Core MVC requires public controllers for controller discovery.")]
/// <summary>
/// Handles the main pages of the application.
/// </summary>
public class HomeController : Controller
{
    /// <summary>
    /// Returns the main page of the application.
    /// </summary>
    /// <returns>The main page.</returns>
    public IActionResult Index()
    {
        return this.View();
    }

    /// <summary>
    /// Returns the privacy page of the application.
    /// </summary>
    /// <returns>The privacy page.</returns>
    public IActionResult Privacy()
    {
        return this.View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    /// <summary>
    /// Returns the error page of the application.
    /// </summary>
    /// <returns>The error page.</returns>
    public IActionResult Error()
    {
        // Create a new instance of the ErrorViewModel and set the RequestId property
        return this.View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier,
        });
    }
}