using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FurnitureShop.DAL;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Controllers
{
    public class AjaxController : Controller
    {
        private readonly FurnitureContext _context;
        private readonly UserManager<FurnitureUser> _manager;
        public AjaxController(FurnitureContext context, UserManager<FurnitureUser> manager)
        {
            _context = context;
            _manager = manager;
        }
        [HttpPost]
        public async Task<IActionResult> AddToFavorites(int id)
        {
            var user =  await _manager.GetUserAsync(HttpContext.User);
            await _context.Favorites.AddAsync(new Models.Favorite {
                ProductId=id,
                UserId = user.Id
            });
            await _context.SaveChangesAsync();



            return Json(new
            {
                status = 200,
                message = "Product Added To Cart Successfully",
            });
        }
    }
}