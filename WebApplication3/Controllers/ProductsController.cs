using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication3.Helpers;


namespace WebApplication3.Controllers
{
    public class ProductsController : Controller
    {
        ShopPD422Db context;
        public ProductsController(ShopPD422Db context)
        {
            this.context = context;
        }
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
        
        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);

            if (product == null) return NotFound();//404

            LoadCategories();
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var item = context.Products.Find(id);
            if (item == null) return NotFound();
            context.Products.Remove(item);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            LoadCategories();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {

            if(!ModelState.IsValid) return RedirectToAction(nameof(Create));

            context.Products.Add(product);

            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public void LoadCategories()
        {
            ViewBag.CategoryList = new SelectList(context.Categories.ToList(), nameof(Category.Id), nameof(Category.Name));
        }
    }
}
