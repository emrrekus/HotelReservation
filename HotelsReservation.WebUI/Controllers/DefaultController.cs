using HotelsReservation.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelsReservation.WebUI.Controllers
{
public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}

