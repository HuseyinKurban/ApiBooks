using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.Areas.Admin.ViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
