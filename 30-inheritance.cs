//https://www.hackerrank.com/challenges/30-inheritance/problem?isFullScreen=true

string[] inputs = Console.ReadLine().Split();
string firstName = inputs[0];
string lastName = inputs[1];
int id = Convert.ToInt32(inputs[2]);

int numScores = Convert.ToInt32(Console.ReadLine());
inputs = Console.ReadLine().Split();
int[] scores = new int[numScores];

for (int i = 0; i < numScores; i++)
    scores[i] = Convert.ToInt32(inputs[i]);

Student studentObj = new Student(firstName, lastName, id, scores);
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

        if (100 >= average && average >= 90)
            return "O";
        if (90 > average && average >= 80)
            return "E";
        if (80 > average && average >= 70)
            return "A";
        if (70 > average && average >= 55)
            return "P";
        if (55 > average && average >= 40)
            return "D";
        else
            return "T";
    }
}
