using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entity;

public class PriceOffers
{
    [Key]
    public int PriceOfferId { get; set; }
    public decimal NewPrice { get; set; }
    public string PromotionalText { get; set; } = string.Empty;
    
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
}
