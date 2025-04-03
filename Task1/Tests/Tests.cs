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
    public void AppendTesting()
    {
        var list = new LinkedList.LinkedList<int>();

        list.Append(1);

        list.Append(2);

        list.Append(3);

        var listAsIEnumerable = list.ConvertToIEnumerable();

        IEnumerable<int> expectedResult = [1, 2, 3];

        Assert.That(listAsIEnumerable, Is.EqualTo(expectedResult));
    }

    /// <summary>
    /// Tests LinkedList.RemoveAllRepeats() on int as type parameter.
    /// </summary>
    [Test]
    public void RemoveAllRepeats_OnInt()
    {
        var list = new LinkedList.LinkedList<int>();

        list.Append(1);

        list.Append(2);

        list.Append(3);

        list.Append(2);

        list.Append(2);

        list.RemoveAllRepeats();

        var listAsIEnumerable = list.ConvertToIEnumerable();

        IEnumerable<int> expectedResult = [1, 2, 3, 2];

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
