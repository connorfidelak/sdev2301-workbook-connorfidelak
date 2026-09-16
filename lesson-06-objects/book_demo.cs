Book book1 = new Book("The Hobbit", "J.R.R. Tolkin", 374);
Book book2 = new Book("The Bible", "Jesus", 2780);

book1.Title = "The Hobbit - Updated";
// book1.Author = "J.R.R. Tolkin";
// Console.WriteLine(book1.Title);
// Console.WriteLine(book1.Author);

book1.PrintSummary();
book2.PrintSummary();
class Book
{
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int Pages { get; set; }
    public Book(string title, string author, int pages)
    {
        this.Title = title;
        this.Author = author;
        this.Pages = pages;
    }

    public void PrintSummary()
    {
        Console.WriteLine($"{Title} by {Author} has {Pages} pages.");
    }


}
