using Microsoft.AspNetCore.Mvc;

namespace HotelsReservation.WebUI.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}


