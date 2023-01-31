using Microsoft.AspNetCore.Mvc;

namespace Collage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }
    }
}
