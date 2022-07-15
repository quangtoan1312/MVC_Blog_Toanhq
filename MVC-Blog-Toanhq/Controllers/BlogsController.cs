using Microsoft.AspNetCore.Mvc;

namespace MVC_Blog_Toanhq.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
