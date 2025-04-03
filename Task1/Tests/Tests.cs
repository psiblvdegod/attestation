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
    /// Tests ... on ...
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
}
