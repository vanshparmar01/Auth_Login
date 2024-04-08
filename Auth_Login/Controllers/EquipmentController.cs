using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerceSite.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            // This is just a sample code, you should replace it with your own data access logic
            var products = new List<Product>
            {
               
            };

            return View(products);
        }
    }

    //public class Product
    //{
    //    public int Id { get; set; }
    //    public required string Name { get; set; }
    //    public required string Description { get; set; }
    //    public decimal Price { get; set; }
    //    public decimal OldPrice { get; set; }
    //    public required string ImageUrl { get; set; }
    //    public float Rating { get; set; }
    //    public int ReviewsCount { get; set; }
    //    public bool IsNew { get; set; }
    //}
}