using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
