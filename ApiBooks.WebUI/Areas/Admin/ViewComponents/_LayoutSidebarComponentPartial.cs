using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.Areas.Admin.ViewComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
