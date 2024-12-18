class Program
{
    static void Main(string[] args)
    {
        // Create some books
        Book book1 = new Book(1, "The Catcher in the Rye", "J.D. Salinger", 10.99m);
        Book book2 = new Book(2, "1984", "George Orwell", 14.99m);
        Book book3 = new Book(3, "To Kill a Mockingbird", "Harper Lee", 12.49m);

        // Display book details
        book1.DisplayDetails();
        book2.DisplayDetails();
        book3.DisplayDetails();

        // Create an invoice
        Invoice invoice = new Invoice(101);
        invoice.AddBook(book1);
        invoice.AddBook(book2);

        // Generate and display the invoice
        invoice.GenerateInvoice();
    }
}
