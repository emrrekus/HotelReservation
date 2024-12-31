
using Microsoft.AspNetCore.Mvc;

namespace HotelsReservation.WebUI.ViewComponents
{
    public class _AboutUsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View();
        }
    }
}
