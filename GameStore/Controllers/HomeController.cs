using GameStore.Interfaces;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduct _products;

        public HomeController(IProduct products)
        {
            _products = products;
        }
        [HttpGet]
        public IActionResult Index()
        {
            System.Console.Clear();
            return View(_products.GetAllProducts());
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _products.AddProduct(product);
            return RedirectToAction(nameof(Index));
        }
    }

}