using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entity;

public class Review
{
    [Key]
    public int ReviewId { get; set; }
    public string VoterName { get; set; } = string.Empty;
    public int NumStars { get; set; }
    public string Comment { get; set; } = string.Empty;
    
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
}
