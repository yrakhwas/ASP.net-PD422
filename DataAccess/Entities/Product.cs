using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This field is required"), MinLength(2, ErrorMessage ="Length must be more than 2 symbols")]
        public string Name { get; set; }
        [Range(0, double.MaxValue, ErrorMessage ="Price must be more than 0")]
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; } 
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
