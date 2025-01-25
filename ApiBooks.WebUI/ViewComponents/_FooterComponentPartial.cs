using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
