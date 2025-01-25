using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _FooterBottomComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
