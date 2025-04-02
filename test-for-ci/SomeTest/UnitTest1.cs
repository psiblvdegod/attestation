// <copyright file="UnitTest1.cs" company="SomeCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SomeTest;

/// <summary>
/// SomeComment.
/// </summary>
public class UnitTest1
{
    /// <summary>
    /// SomeComment.
    /// </summary>
    [Test]
    public void Test1()
    {
        var element = new SomeClass.SomeClass(1);

        Assert.That(element.Data, Is.EqualTo(1));

        element.Data = 2;

        Assert.That(element.Data, Is.EqualTo(2));
    }
}
