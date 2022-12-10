
//https://www.hackerrank.com/challenges/30-abstract-classes/problem?isFullScreen=true

class MyBook : Book
{
    public int Price { get; set; }

    public MyBook(string title, string author, int price)
    : base(title, author)
    {
        Price = price;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Price: {Price}");
    }
}

abstract class Book
{

    protected string title;
    protected string author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();
}