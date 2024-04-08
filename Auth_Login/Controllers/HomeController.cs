using Auth_Login.Data;
using Auth_Login.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_Login.Controllers
{
    public class HomeController : Controller
    {
        private readonly Appdbcontext _context;

        public HomeController(Appdbcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.signup.FirstOrDefaultAsync(u => u.Email == login.Email && u.password == login.Password);

                if (user != null)
                {
                    // Successful login, redirect to Home page
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password");
                    return View();
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Equipment()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Shoppingcart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
