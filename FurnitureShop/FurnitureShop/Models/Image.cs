using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureShop.Models
{
    public class Image
    {
        public int Id { get; set; }
        [StringLength(300)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainPhoto { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
