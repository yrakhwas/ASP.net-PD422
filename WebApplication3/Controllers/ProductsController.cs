using Microsoft.AspNetCore.Mvc;
using WebApplication3.Helpers;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductsController : Controller
    {

        List<Product> products;
        public ProductsController()
        {
            products = Seeder.GetProducts();
        }

        public IActionResult Index()
        {
            return View(products);
        }
    }
}
