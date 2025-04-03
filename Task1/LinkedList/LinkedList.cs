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

    private class Node(T data)
    {
        public Node? Next {get; set;}

        public T Data { get; set; } = data;
    }
}
