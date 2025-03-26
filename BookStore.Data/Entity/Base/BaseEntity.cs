using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entity.Base;

public class BaseEntity : IBaseEntity
{
    [Key]
    public int Id { get; set; }
}