using Microsoft.AspNetCore.Mvc;

namespace MoskPharmacy.Controllers;
public class MapController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
