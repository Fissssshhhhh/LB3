using polityko_lb3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace polityko_lb3.Models.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Add(int productId)
        {
            return View(StaticDB.Products.FirstOrDefault(x=>x.Id == productId));
        }
    }
}
