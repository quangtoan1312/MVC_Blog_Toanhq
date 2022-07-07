using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC_Blog_Toanhq.Controllers
{
    public class BlogController : Controller
    {

        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
