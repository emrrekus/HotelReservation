using Microsoft.AspNetCore.Mvc;

namespace HotelsReservation.WebUI.ViewComponents
{
    public class _ScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
