using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureShop.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(300)]
        public string CategoryImage { get; set; }

        [NotMapped]
        public IFormFile CategoryPhoto { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
