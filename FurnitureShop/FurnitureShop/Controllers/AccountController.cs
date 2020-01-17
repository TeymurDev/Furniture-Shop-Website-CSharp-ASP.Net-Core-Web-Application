using FurnitureShop.DAL;
using FurnitureShop.Models;
using FurnitureShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FurnitureShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly FurnitureContext _context;
        private readonly UserManager<FurnitureUser> _userManager;
        private readonly SignInManager<FurnitureUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(FurnitureContext context,
            UserManager<FurnitureUser> userManager, SignInManager<FurnitureUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }

            FurnitureUser user = registerModel;

            IdentityResult result = await _userManager.CreateAsync(user, registerModel.Password);//implicit    

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(registerModel);
            }

     

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            FurnitureUser user = await _userManager.FindByEmailAsync(loginModel.EmailOrUsername);

            if (user == null)
            {
                user = await _userManager.FindByNameAsync(loginModel.EmailOrUsername);
            }

            if (user == null)
            {
                ModelState.AddModelError("", "Email or password is invalid");
                return View(loginModel);
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.RememberMe, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Email or password is invalid");
            return View(loginModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

    }
}