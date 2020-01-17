using FurnitureShop.DAL;
using FurnitureShop.Extensions;
using FurnitureShop.Models;
using FurnitureShop.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FurnitureShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class ProductsController : Controller
    {
        private readonly FurnitureContext _context;
        private readonly IHostingEnvironment _env;
        public ProductsController(FurnitureContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                Products = _context.Products.Include(c => c.Images).ToList()
            };
            return View(homeIndexVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                Product = new Models.Product()
            };


            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name");
            return View(homeIndexVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeIndexVM homeIndexVM)
        {

            if (!ModelState.IsValid)
            {
                return View(homeIndexVM);
            }
            List<IFormFile> files = new List<IFormFile>();
            foreach (var item in homeIndexVM.MainPhotos)
            {
                if (item == null)
                {
                    ModelState.AddModelError("MainPhoto", "Image should be selected");
                    return View(homeIndexVM);
                }

                if (!item.IsImage())
                {
                    ModelState.AddModelError("MainPhoto", "Image type is not valid");
                    return View(homeIndexVM);
                }

                if (!item.IsSmaller(1))
                {
                    ModelState.AddModelError("MainPhoto", "Image size can be maximum 1 mb");
                    return View(homeIndexVM);
                }
                files.Add(item);
               
            }
            await _context.Products.AddAsync(new Product
            {
                Name = homeIndexVM.Product.Name,
                Price = homeIndexVM.Product.Price,
                HasDiscount = homeIndexVM.Product.HasDiscount,
                DiscountedPrice = homeIndexVM.Product.DiscountedPrice,
                Height = homeIndexVM.Product.Height,
                Width = homeIndexVM.Product.Width,
                Length = homeIndexVM.Product.Length,
                CategoryId = homeIndexVM.Product.CategoryId
            });
            await _context.SaveChangesAsync();
            var ProId = _context.Products.LastOrDefault().Id;
            foreach (var item in files)
            {
                var Image = await item.SaveFileAsync(_env.WebRootPath, "img/product");
                await _context.Images.AddAsync(new Image {
                    MainImage = Image,
                    ProductId = ProId
                });
               await _context.SaveChangesAsync();
            }           
            return RedirectToAction(nameof(Index));
        }

    }
}