using System;
using System.Collections.Generic;

public class Library
{
    public List<Book> books;
    
    public Library()
    {
        books = new List<Book>();
    }
    
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    
    public void ShowBooks()
    {
        if (books.Count != 0)
        {
            Console.WriteLine("Available books:");
            foreach (Book book in books)
            {
                Console.WriteLine(book.GetInfo());
            }
        }
        else
        {
            Console.WriteLine("There are no books in the library");
        }
    }
    
    public void FindBook(string Title)
    {
        bool foundBook = false;
        foreach (Book book in books)
        {
            if (Title == book.title)
            {
                Console.WriteLine($"Found book \"{Title}\":\n{book.GetInfo()}");
                foundBook = true;
            }
        }
        if (foundBook == false)
        {
            Console.WriteLine($"Book \"{Title}\" was not found in the library.");
        }
    }
}
