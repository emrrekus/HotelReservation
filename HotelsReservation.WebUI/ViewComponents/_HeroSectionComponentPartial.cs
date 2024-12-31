using Microsoft.AspNetCore.Mvc;

namespace HotelsReservation.WebUI.ViewComponents
{
    public class _HeroSectionComponentPartial : ViewComponent
    {
    public IViewComponentResult Invoke()
    {
        return View();
     }
    }
}
