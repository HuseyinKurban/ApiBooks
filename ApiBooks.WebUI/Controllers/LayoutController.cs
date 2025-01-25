using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
