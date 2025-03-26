using System.ComponentModel.DataAnnotations;
using BookStore.Domain.Entity.Base;

namespace BookStore.Domain.Entity;

public class Author : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
}