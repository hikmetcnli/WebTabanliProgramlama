using Microsoft.AspNetCore.Mvc;

namespace Hafta3.Controllers
{
    public class YazarlarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
