using Auth_Login.Data;
using Auth_Login.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Auth_Login.Controllers
{
    public class HomeController1 : Controller
    {
        private readonly Appdbcontext _context;

        public HomeController1(Appdbcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View(new Signup());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Signup(Signup signup)
        {
            ViewBag.Message = "Signup successful!";
            if (ModelState.IsValid)
            {
                try
                {
                    _context.signup.Add(signup);
                    _context.SaveChanges();
                    ViewBag.Message = "Signup successful!";
                    return RedirectToAction("Index");
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError("", "An error occurred during signup. Please try again.");
                    return View("Signup", signup);
                }
            }
            return View("Signup", signup);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new UserLogin());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                var user = _context.signup.SingleOrDefault(u => u.Email == login.Email && u.password == login.Password);

                if (user != null)
                {
                    // Successful login, redirect to dashboard
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password");
                }
            }
            return View(login);
        }


        public IActionResult Dashboard()
        {
            // Implement dashboard action as needed
            return View();
        }
    }
}
