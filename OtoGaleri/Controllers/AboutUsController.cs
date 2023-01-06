using Microsoft.AspNetCore.Mvc;

namespace OtoGaleri.Controllers;

public class AboutUsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}