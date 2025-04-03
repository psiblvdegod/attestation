namespace LinkedList;

public class LinkedList<T> : ILinkedList<T>
{
    private Node? head;

    private Node? tail;

    public void Append(T data)
    {
        var newNode = new Node(data);

        if (head == null || tail == null)
        {
            head = newNode;
            tail = newNode;
            return;
        }

        if (head.Next == null)
        {
            head.Next = newNode;
            tail = newNode;
            return;
        }

        tail.Next = newNode;
        tail = newNode;
    }

    public void RemoveAllRepeats()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> ConvertToIEnumerable()
    {
        IEnumerable<T> result = [];

        var current = head;

        while (current is not null)
        {
            result = result.Append(current.Data);

            current = current.Next;
        }

        return result;
    }

    private class Node(T data)
    {
        public Node? Next {get; set;}

        public T Data { get; set; } = data;
    }
}
