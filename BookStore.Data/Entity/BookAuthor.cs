namespace BookStore.Domain.Entity;

public class BookAuthor
{
    public int Order { get; set; }
    
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
    
    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;
}
