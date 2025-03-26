using System.ComponentModel.DataAnnotations;
using BookStore.Domain.Entity.Base;

namespace BookStore.Domain.Entity;

public class PriceOffers : BaseEntity
{
    public decimal NewPrice { get; set; }
    public string PromotionalText { get; set; } = string.Empty;
    
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
}
