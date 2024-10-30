public class Book
{
	public string title;
	public string author;
	public int pages;
    
    public Book(string Title, string Author, int Pages)
    {
        title = Title;
        author = Author;
        pages = Pages;
    }

    public string GetInfo()
	{
		return $"{title} by {author} ({pages} pages)";
	}
}
