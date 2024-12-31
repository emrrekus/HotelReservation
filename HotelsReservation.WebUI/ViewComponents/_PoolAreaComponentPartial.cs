using Microsoft.AspNetCore.Mvc;

namespace HotelsReservation.WebUI.ViewComponents
{
    public class _PoolAreaComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View();
        }
    }
}

