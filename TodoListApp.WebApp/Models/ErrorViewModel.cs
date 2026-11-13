// <copyright file="ErrorViewModel.cs" company="TodoListApp">
// Copyright (c) TodoListApp. All rights reserved.
// </copyright>

namespace TodoListApp.WebApp.Models;

internal sealed class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);
}