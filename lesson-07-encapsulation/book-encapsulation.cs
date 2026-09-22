using System.Linq.Expressions;

class Program
{
    static void Main()
    {

        try
        {
            Book book = new Book("Clean Code", 464);
            book.Pages = 500;
            book.Pages = 50;
            Console.WriteLine($"{book.Title}: {book.Pages} pages");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    class Book
    {
        public string Title { get; }
        private int _pages;
        public int Pages
        {
            get => _pages;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Pages must be greater than zero.");
                _pages = value;
            }
        }
        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }
    }
}