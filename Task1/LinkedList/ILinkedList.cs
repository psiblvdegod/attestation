// <copyright file="ILinkedList.cs" author="psiblvdegod">
// under MIT License.
// </copyright>

namespace LinkedList;

/// <summary>
/// Declare methods of data structure "Linked List".
/// </summary>
/// <typeparam name="T">Type of elements in the list.</typeparam>
public interface ILinkedList<T>
{
    /// <summary>
    /// Adds element to the end of the list.
    /// </summary>
    /// <param name="data">Element which will be added.</param>
    public void Append(T data);

    /// <summary>
    /// Deletes consecutive identical elements.
    /// </summary>
    public void RemoveAllRepeats();

    /// <summary>
    /// Represents elements of the list as IEnumerable.
    /// </summary>
    /// <returns>Elements of the list as IEnumerable.</returns>
    public IEnumerable<T> ConvertToEnumerable();
}
