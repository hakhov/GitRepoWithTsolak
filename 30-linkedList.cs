Node? linkedList = null;
int count = Int32.Parse(Console.ReadLine());

while (count-- > 0)
{
    int data = Int32.Parse(Console.ReadLine());
    linkedList = InsertElement(linkedList, data);
}

RemoveDuplicates(linkedList);

Display(linkedList);

static void Display(Node? linkedList)
{
    Node? start = linkedList;
    while (start is not null)
    {
        Console.Write(start.Data + " ");
        start = start.Next;
    }
}

static Node InsertElement(Node? linkedList, int data)
{
    Node current = new Node(data);

    if (linkedList is null)
    {
        linkedList = current;
    }
    else if (linkedList.Next is null)
    {
        linkedList.Next = current;
    }
    else
    {
        Node start = linkedList;
        while (start.Next is not null)
        {
            start = start.Next;
        }
        start.Next = current;
    }
    return linkedList;
}

static Node? RemoveDuplicates(Node linkedList)
{
    var current = linkedList;
    while (current is not null && current.Next is not null)
    {
        while (current?.Data == current?.Next?.Data)
        {
            current.Next = current?.Next?.Next;
        }
        current = current?.Next;

    }
    return linkedList;
}

class Node
{
    public int Data;
    public Node? Next;
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}
