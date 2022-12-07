
//https://www.hackerrank.com/challenges/30-abstract-classes/problem?isFullScreen=true

class MyBook : Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Price { get; set; }

    public MyBook(string title, string author, int price)
    : base(title, author)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Price: {Price}");
    }
}