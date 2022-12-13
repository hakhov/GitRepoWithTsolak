string? text = Console.ReadLine();

PalidromeSoulation instancePalidromeSoulation = new PalidromeSoulation();

foreach (char symbol in text)
{
    instancePalidromeSoulation.PushCharacter(symbol);
    instancePalidromeSoulation.EnqueueCharacter(symbol);
}

bool isPalindrome = true;

for (int i = 0; i < text.Length / 2; i++)
{
    if (instancePalidromeSoulation.PopCharacter() != instancePalidromeSoulation.DequeueCharacter())
    {
        isPalindrome = false;

        break;
    }
}

Console.WriteLine(isPalindrome ? $"The word, {text}, is a palindrome."
    : $"The word, {text}, is not a palindrome.");

class PalidromeSoulation
{
    Queue<char> queue = new Queue<char>();
    Stack<char> stack = new Stack<char>();

    public void PushCharacter(char symbol) => stack.Push(symbol);
    public char PopCharacter() => stack.Pop();
    public void EnqueueCharacter(char symbol) => queue.Enqueue(symbol);
    public char DequeueCharacter() => queue.Dequeue();
}