string? txt = Console.ReadLine();

Solution obj = new Solution();

foreach (char cr in txt)
{
	obj.PushCharacter(cr);
	obj.EnqueueCharacter(cr);
}

bool isPalindrome = true;

for (int i = 0; i < txt.Length / 2; i++)
{
	if (obj.PopCharacter() != obj.DequeueCharacter())
	{
		isPalindrome = false;

		break;
	}
}


if (isPalindrome)
{
	Console.Write($"The word, {txt}, is a palindrome.");
}
else
{
	Console.Write($"The word, {txt}, is not a palindrome.");
}

class Solution
{
	Queue<char> queue = new Queue<char>();
	Stack<char> stack = new Stack<char>();

	public void PushCharacter(char cr) => stack.Push(cr);
	public char PopCharacter() => stack.Pop();
	public void EnqueueCharacter(char cr) => queue.Enqueue(cr);
	public char DequeueCharacter() => queue.Dequeue();
}