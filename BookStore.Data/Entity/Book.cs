using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookStore.Domain.Entity.Base;

namespace BookStore.Domain.Entity;

public class Book : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime? PublishedOn { get; set; }
    public string Publisher { get; set; } = string.Empty;
    [Column(TypeName = "decimal(8,2)")]
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public bool SoftDeleted { get; set; }
    
    public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public PriceOffers? PriceOffer { get; set; }
}
