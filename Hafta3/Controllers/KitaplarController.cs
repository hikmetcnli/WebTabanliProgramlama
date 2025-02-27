using Microsoft.AspNetCore.Mvc;

namespace Hafta3.Controllers
{
    public class KitaplarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
