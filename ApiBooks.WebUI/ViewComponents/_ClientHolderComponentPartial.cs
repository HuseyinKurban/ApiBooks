using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _ClientHolderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
