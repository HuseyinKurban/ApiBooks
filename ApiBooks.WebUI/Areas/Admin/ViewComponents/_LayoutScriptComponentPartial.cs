using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.Areas.Admin.ViewComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
