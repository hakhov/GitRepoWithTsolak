string[] inputs = Console.ReadLine().Split();
string firstName = inputs[0];
string lastName = inputs[1];
int id = Convert.ToInt32(inputs[2]);

int numScores = Convert.ToInt32(Console.ReadLine());
inputs = Console.ReadLine().Split();
int[] scores = new int[numScores];

for (int i = 0; i < numScores; i++)
{
    scores[i] = Convert.ToInt32(inputs[i]);
}

var studentObj = new Student(firstName, lastName, id, scores);
studentObj.PrintPerson();
Console.WriteLine($"Grade: {studentObj.Calculate()}");

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ID { get; set; }

    public Person(string firstName, string lastName, int id)
    {
        FirstName = firstName;
        LastName = lastName;
        ID = id;
    }

    public Person()
    {

    }

    public void PrintPerson()
    {
        Console.WriteLine($"Name: {LastName}, {FirstName}");
        Console.WriteLine($"ID: {ID}");
    }

}

class Student : Person
{
    private int[] testScores;
    public Student(string firstName, string lastName, int id, int[] scores)
        : base(firstName, lastName, id)
    {
        testScores = scores;
    }

    public string Calculate()
    {
        int average = testScores.Sum() / testScores.Length;

        return average switch
        {
            <= 100 and >= 90 => "O",
            < 90 and >= 80 => "E",
            < 80 and >= 70 => "A",
            < 70 and >= 55 => "P",
            < 55 and >= 40 => "D",
            _ => "t",
        };
    }