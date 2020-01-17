using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureShop.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual FurnitureUser FurnitureUser { get; set; }
    }
}
