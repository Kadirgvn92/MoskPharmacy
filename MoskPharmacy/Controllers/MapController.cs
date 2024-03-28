using Microsoft.AspNetCore.Mvc;
using MoskPharmacy.Context;
using MoskPharmacy.Models;
using MoskPharmacy.ViewModels;
using NetTopologySuite.Features;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Text.Json;
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
        var reader = new GeoJsonReader();
        var geometry = reader.Read<Geometry>(geoJsonData.ToString());
        // Convert the relevant part of the JsonNode to a Geometry object
        var drawing = new Drawing
        {
            Type = geoJsonData["type"].ToString(),
            Geometry = geometry
        };
        

        _context.Drawings.Add(drawing);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult GetGeo()
    {
        var values = _context.Drawings.ToList();


        return View(values);
    }
}
