using FurnitureShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureShop.ViewModels
{
    public class RegisterModel
    {
        [Required]
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }


        public static implicit operator FurnitureUser(RegisterModel registerModel)
        {
            return new FurnitureUser
            {
                Firstname = registerModel.Firstname,
                Lastname = registerModel.Lastname,
                Email = registerModel.Email,
                UserName = registerModel.Username
            };
        }
    }
}
