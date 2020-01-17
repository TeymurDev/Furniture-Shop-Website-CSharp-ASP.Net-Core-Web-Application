using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.ViewModels
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Email or username")]
        public string EmailOrUsername { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
