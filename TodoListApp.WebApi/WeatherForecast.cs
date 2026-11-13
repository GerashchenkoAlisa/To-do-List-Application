// <copyright file="WeatherForecast.cs" company="TodoListApp">
// Copyright (c) TodoListApp. All rights reserved.
// </copyright>

namespace TodoListApp.WebApi
{
    /// <summary>
    /// Represents weather forecast information.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Design",
        "CA1515:Consider making public types internal",
        Justification = "This type is used as the response model of a public API controller.")]
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets the forecast date.
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Gets or sets the temperature in Celsius.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets the temperature in Fahrenheit.
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets the weather summary.
        /// </summary>
        public string? Summary { get; set; }
    }
}
