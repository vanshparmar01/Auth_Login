using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerceSite.Controllers
{
    public class ProductController : Controller
    {
        
        public class Product
        {
            public int Id { get; set; }
            public required string Name { get; set; }
            public required string Description { get; set; }
            public decimal Price { get; set; }
            public float Rating { get; set; }
            public int ReviewsCount { get; set; }
            public int SoldCount { get; set; }
            public required List<string> Images { get; set; }
        }
    }
}