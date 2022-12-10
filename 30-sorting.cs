int count = Convert.ToInt32(Console.ReadLine().Trim());

List<int> array = Console.ReadLine().TrimEnd().Split(' ').ToList()
                         .Select(aTemp => Convert.ToInt32(aTemp))
                         .ToList();
int numberOfSwaps = 0;

for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;

            numberOfSwaps++;
        }
    }
    if (numberOfSwaps == 0)
    {
        break;
    }
}


Console.WriteLine($"Sorted Array: {string.Join(',', array)} ");

Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
Console.WriteLine($"First Element: {array.First()}");
Console.WriteLine($"Last Element: {array.Last()}");