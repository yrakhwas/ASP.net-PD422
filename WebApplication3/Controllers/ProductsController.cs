using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Helpers;


namespace WebApplication3.Controllers
{
    public class ProductsController : Controller
    {
        ShopPD422Db context = new ShopPD422Db();

        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }
        public IActionResult Details(int id)
        {
            if(id<0) return BadRequest();//400

            var product = context.Products.Find(id);

            if(product ==null) return NotFound();//404

            return View(product);
        }
    }
}
