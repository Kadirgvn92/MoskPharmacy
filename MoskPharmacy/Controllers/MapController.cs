using Microsoft.AspNetCore.Mvc;
using MoskPharmacy.Context;
using MoskPharmacy.Models;
using MoskPharmacy.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

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
    public IActionResult SaveGeoJson([FromBody] JsonObject geoJsonData)
    {

        var values = new Drawing()
        {
            Type = geoJsonData.ToString(),
        };

        _context.Drawings.Add(values);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
