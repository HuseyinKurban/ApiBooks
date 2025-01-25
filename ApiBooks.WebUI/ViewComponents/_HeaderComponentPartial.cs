using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _HeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
