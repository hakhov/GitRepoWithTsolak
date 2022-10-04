//https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem?isFullScreen=true

int count = int.Parse(Console.ReadLine());

Dictionary<string, string> phoneBook = new Dictionary<string, string>();

List<string> phoneBookNames = new List<string>();
List<string> input = new List<string>();

for (int i = 0; i < count; i++)
{
    input = Console.ReadLine().ToLower().TrimEnd().Split(' ').ToList();
    phoneBook.Add(input[0], input[1]);
}

for (int i = 0; i < count; i++)
    phoneBookNames.Add(Console.ReadLine().ToLower().TrimEnd());

foreach (var item in phoneBookNames)
    Console.WriteLine(phoneBook.ContainsKey(item) ? item + "=" + phoneBook[item] : "Not found");


