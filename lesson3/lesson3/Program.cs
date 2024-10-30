namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            
            Book book1 = new Book("1984", "George Orwell", 328);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 281);
            Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);
            
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            
            library.ShowBooks();

            library.FindBook("Crime and Punishment");
            library.FindBook("To Kill a Mockingbird");
        }
    }
}
