using FurnitureShop.DAL;
using FurnitureShop.Models;
using FurnitureShop.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using static FurnitureShop.Extensions.IFormFileExtensions;
using FurnitureShop.Extensions;
using System;

namespace FurnitureShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class CategoriesController : Controller
    {
        private readonly FurnitureContext _context;
        private readonly IHostingEnvironment _env;
        public CategoriesController(FurnitureContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                Categories = _context.Categories.ToList()
            };
            return View(homeIndexVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {

            if (!ModelState.IsValid)
            {
                return View(category);
            }

            if (category.CategoryPhoto == null)
            {
                ModelState.AddModelError("CategoryPhoto", "Image should be selected");
                return View(category);
            }

            if (!category.CategoryPhoto.IsImage())
            {
                ModelState.AddModelError("CategoryPhoto", "Image type is not valid");
                return View(category);
            }

            if (!category.CategoryPhoto.IsSmaller(1))
            {
                ModelState.AddModelError("CategoryPhoto", "Image size can be maximum 1 mb");
                return View(category);
            }

            category.CategoryImage = await category.CategoryPhoto.SaveFileAsync(_env.WebRootPath, "img/feature");

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            Category category = await _context.Categories.FindAsync(id);

            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            var categoryDb = await _context.Categories.FindAsync(category.Id);

            if (category.CategoryPhoto != null)
            {
                try
                {
                    var newPhoto = await category.CategoryPhoto.SaveFileAsync(_env.WebRootPath, "img/feature");

                    IFormFileExtensions.Delete(_env.WebRootPath, "img/feature", categoryDb.CategoryImage);

                    categoryDb.CategoryImage = newPhoto;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(category);
                }
            }

            categoryDb.Name = category.Name;

            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (_context.Categories.Count() <= 2)
            {
                return RedirectToAction(nameof(Index));
            }

            if (id == null) return NotFound();

            Category category = await _context.Categories.FindAsync(id);

            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

            Category category = await _context.Categories.FindAsync(id);

            if (category == null) return NotFound();


            IFormFileExtensions.Delete(_env.WebRootPath, "img/feature", category.CategoryImage);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            //TempData["success_message"] = "Category was removed successfully";

            return RedirectToAction(nameof(Index));
        }
    }
}