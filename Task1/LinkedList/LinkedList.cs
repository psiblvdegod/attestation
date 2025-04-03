// <copyright file="LinkedList.cs" author="psiblvdegod">
// under MIT License.
// </copyright>

namespace LinkedList;

/// <summary>
/// Implements data structure "Linked list".
/// </summary>
/// <typeparam name="T">Type of elements in the list.</typeparam>
public class LinkedList<T> : ILinkedList<T>
{
    private Node? head;

    private Node? tail;

    /// <inheritdoc/>
    public void Append(T data)
    {
        var newNode = new Node(data);

        if (this.head == null || this.tail == null)
        {
            this.head = newNode;
        }
        else if (this.head.Next == null)
        {
            this.head.Next = newNode;
        }
        else
        {
            this.tail.Next = newNode;
        }

        this.tail = newNode;
    }

    /// <inheritdoc/>
    public void RemoveAllRepeats()
    {
        if (this.head == null)
        {
            throw new InvalidOperationException("list is empty.");
        }

        var prev = this.head;

        var current = this.head.Next;

        while (current != null)
        {
            if (Equals(prev.Data, current.Data))
            {
                current = current.Next;
                prev.Next = current;
            }
            else
            {
                prev = current;
                current = current.Next;
            }
        }
    }

    /// <inheritdoc/>
    public IEnumerable<T> ConvertToEnumerable()
    {
        IEnumerable<T> result = [];

        var current = this.head;

        while (current is not null)
        {
            result = result.Append(current.Data);

            current = current.Next;
        }

        return result;
    }

    private class Node(T data)
    {
        public Node? Next { get; set; }

        public T Data { get; set; } = data;
    }
}
