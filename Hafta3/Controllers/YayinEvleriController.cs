using Microsoft.AspNetCore.Mvc;

namespace Hafta3.Controllers
{
    public class YayinEvleriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
