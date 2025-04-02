// <copyright file="SomeClass.cs" company="SomeCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SomeClass;

/// <summary>
/// SomeComment.
/// </summary>
/// <param name="data">SomeComment..</param>
public class SomeClass(int data)
{
    /// <summary>
    /// Gets or sets SomeComment.
    /// </summary>
    public int Data { get; set; } = data;
}
