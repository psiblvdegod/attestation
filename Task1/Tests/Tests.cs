// <copyright file="Tests.cs" author="psiblvdegod">
// under MIT License.
// </copyright>

namespace Tests;

/// <summary>
/// Tests methods of class .
/// </summary>
public class Tests
{
    /// <summary>
    /// Tests LinkedList.Append() on int as type parameter.
    /// </summary>
    [Test]
    public void Append_OnInt()
    {
        var list = new LinkedList.LinkedList<int>();

        int[] inputData = [5, 4, 3, 2, 1];

        foreach (var i in inputData)
        {
            list.Append(i);
        }

        var listAsIEnumerable = list.ConvertToIEnumerable();

        IEnumerable<int> expectedResult = [5, 4, 3, 2, 1];

        Assert.That(listAsIEnumerable, Is.EqualTo(expectedResult));
    }

    /// <summary>
    /// Tests LinkedList.Append() on string as type parameter.
    /// </summary>
    [Test]
    public void Append_OnString()
    {
        var list = new LinkedList.LinkedList<string>();

        string[] inputData = ["5", "4", "3", "2", "1"];

        foreach (var i in inputData)
        {
            list.Append(i);
        }

        var listAsIEnumerable = list.ConvertToIEnumerable();

        IEnumerable<string> expectedResult = ["5", "4", "3", "2", "1"];

        Assert.That(listAsIEnumerable, Is.EqualTo(expectedResult));
    }

    /// <summary>
    /// Tests LinkedList.RemoveAllRepeats() on int as type parameter.
    /// </summary>
    [Test]
    public void RemoveAllRepeats_OnInt()
    {
        var list = new LinkedList.LinkedList<int>();

        int[] inputData = [1, 2, 3, 3, 3, 2, 2, 4, 1, 5];

        foreach (var i in inputData)
        {
            list.Append(i);
        }

        list.RemoveAllRepeats();

        var listAsIEnumerable = list.ConvertToIEnumerable();

        IEnumerable<int> expectedResult = [1, 2, 3, 2, 4, 1, 5];

        Assert.That(listAsIEnumerable, Is.EqualTo(expectedResult));
    }

    /// <summary>
    /// Tests LinkedList.RemoveAllRepeats() on string as type parameter.
    /// </summary>
    [Test]
    public void RemoveAllRepeats_OnString()
    {
        var list = new LinkedList.LinkedList<string>();

        string[] inputData = ["123", "234", "234", "234", "123"];

        foreach (var s in inputData)
        {
            list.Append(s);
        }

        list.RemoveAllRepeats();

        var listAsIEnumerable = list.ConvertToIEnumerable();

        IEnumerable<string> expectedResult = ["123", "234", "123"];

        Assert.That(listAsIEnumerable, Is.EqualTo(expectedResult));
    }
}
