using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entity;

public class Author
{
    [Key]
    public int AuthorId { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
}