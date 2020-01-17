using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Models
{
    public class FurnitureUser : IdentityUser
    {
        [StringLength(256)]
        public string Firstname { get; set; }
        [StringLength(256)]
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        [StringLength(256)]
        public string Livingplace { get; set; }
    }
}
