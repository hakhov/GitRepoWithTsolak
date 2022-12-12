
int count = Convert.ToInt32(Console.ReadLine());
int[] intArray = new int[count];
for (int i = 0; i < count; i++)
{
    intArray[i] = Convert.ToInt32(Console.ReadLine());
}

string[] stringArray = new string[count];
for (int i = 0; i < count; i++)
{
    stringArray[i] = Console.ReadLine();
}

PrintArray<Int32>(intArray);
PrintArray<String>(stringArray);

static void PrintArray<T>(T[] array)
{
    Console.Write(string.Join(' ', array));
}