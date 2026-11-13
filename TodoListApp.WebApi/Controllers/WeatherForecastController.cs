// <copyright file="WeatherForecastController.cs" company="TodoListApp">
// Copyright (c) TodoListApp. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;

namespace TodoListApp.WebApi.Controllers;

/// <summary>
/// Provides weather forecast data.
/// </summary>
[ApiController]
[Route("[controller]")]
[System.Diagnostics.CodeAnalysis.SuppressMessage(
    "Design",
    "CA1515:Consider making public types internal",
    Justification = "ASP.NET Core requires public controllers for controller discovery.")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching",
    ];

    /// <summary>
    /// Returns a list of weather forecasts.
    /// </summary>
    /// <returns>A collection of weather forecast records.</returns>
    [HttpGet(Name = "GetWeatherForecast")]
    public static IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = 20 + index,
            Summary = Summaries[index - 1],
        }).ToArray();
    }
}