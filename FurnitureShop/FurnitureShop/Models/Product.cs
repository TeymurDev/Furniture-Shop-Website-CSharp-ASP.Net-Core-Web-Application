using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace FurnitureShop.Models
{
    public class Product
    {
        public Product()
        {
            Images = new HashSet<Image>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool HasDiscount { get; set; }
        public decimal DiscountedPrice { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
