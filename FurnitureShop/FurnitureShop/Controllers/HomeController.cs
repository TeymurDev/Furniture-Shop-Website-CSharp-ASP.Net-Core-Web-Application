using FurnitureShop.DAL;
using FurnitureShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly FurnitureContext _context;

        public HomeController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                Categories = _context.Categories.ToList(),
                Products = _context.Products.Include(c => c.Images).ToList()
            };
            return View(homeIndexVM);
        }

        public IActionResult SingleProduct(int id)
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                Images = _context.Images.Where(v => v.ProductId == id).ToList(),
                Product = _context.Products.Include(p => p.Category).Where(x => x.CategoryId == x.Category.Id).FirstOrDefault(v => v.Id == id)

            };
            return View(homeIndexVM);
        }

    
    }
}

