using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureShop.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public decimal Score { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
