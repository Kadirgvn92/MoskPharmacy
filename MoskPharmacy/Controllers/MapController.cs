using Microsoft.AspNetCore.Mvc;
using MoskPharmacy.Context;
using MoskPharmacy.Models;
using MoskPharmacy.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MoskPharmacy.Controllers;
public class MapController : Controller
{
    private readonly MoskPharmacyContext _context;

    public MapController(MoskPharmacyContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SaveGeoJson([FromBody] JObject geoJsonData)
    {
        var values = JsonConvert.DeserializeObject<List<DrawingViewModel>>(geoJsonData.ToString());
        
        
        return View();
    }
}
