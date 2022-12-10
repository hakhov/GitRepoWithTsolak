Node? linkedList = null;
int T = Int32.Parse(Console.ReadLine());

while (T-- > 0)
{
    int data = Int32.Parse(Console.ReadLine());
    linkedList = InsertElement(linkedList, data);
}

linkedList = RemoveDuplicates(linkedList);

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
    Node tempObj = new Node(data);

    if (linkedList is null)
        linkedList = tempObj;
    else if (linkedList.Next is null)
        linkedList.Next = tempObj;
    else
    {
        Node start = linkedList;
        while (start.Next is not null)
            start = start.Next;
        start.Next = tempObj;
    }
    return linkedList;
}

static Node? RemoveDuplicates(Node? linkedList)
{
    Node? tempObj = linkedList;

    while (tempObj?.Next is not null)
    {
        if (tempObj.Data == tempObj.Next.Data)
        {
            tempObj.Next = tempObj.Next.Next;
        }
        else
        {
            tempObj = tempObj.Next;
        }
    }
    return tempObj;
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
