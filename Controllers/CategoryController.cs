using BookStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext Context;
        public CategoryController(ApplicationDbContext context) {
            Context = context;
        }

        

        public IActionResult Index()
        {
            var category = Context.Categories.ToList();
            return View();
        }
    }
}
