using Microsoft.AspNetCore.Mvc;

namespace MarcoMoreno.Controllers
{
    public class MarcoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
