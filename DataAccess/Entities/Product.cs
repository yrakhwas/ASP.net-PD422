using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MinLength(2)]
        public string Name { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        [Url]
        public string? ImageUrl { get; set; } 
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
