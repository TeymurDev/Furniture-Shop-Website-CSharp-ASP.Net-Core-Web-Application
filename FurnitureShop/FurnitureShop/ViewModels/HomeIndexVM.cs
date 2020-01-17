using FurnitureShop.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace FurnitureShop.ViewModels
{
    public class HomeIndexVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public Image Image { get; set; }
        public List<Image> Images { get; set; }
        public List<IFormFile> MainPhotos { get; set; }
    }
}
