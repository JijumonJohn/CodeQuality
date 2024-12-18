public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    public Book(int id, string title, string author, decimal price)
    {
        Id = id;
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Book ID: {Id}, Title: {Title}, Author: {Author}, Price: {Price:C}");
    }
}

public class Invoice
{
    public int InvoiceId { get; set; }
    public List<Book> Books { get; private set; }
    public decimal TotalAmount => Books.Sum(book => book.Price); // Calculate total dynamically

    public Invoice(int invoiceId)
    {
        InvoiceId = invoiceId;
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        if (book == null) throw new ArgumentNullException(nameof(book));
        Books.Add(book);
    }

    public void GenerateInvoice()
    {
        Console.WriteLine($"Invoice ID: {InvoiceId}");
        Console.WriteLine("Books in Invoice:");
        foreach (var book in Books)
        {
            Console.WriteLine($"- {book.Title} by {book.Author}, Price: {book.Price:C}");
        }
        Console.WriteLine($"Total Amount: {TotalAmount:C}");
    }
}
