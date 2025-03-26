using System.ComponentModel.DataAnnotations;
using BookStore.Domain.Entity.Base;

namespace BookStore.Domain.Entity;

public class Review : BaseEntity
{
    public string VoterName { get; set; } = string.Empty;
    public int NumStars { get; set; }
    public string Comment { get; set; } = string.Empty;
    
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
}
