using Microsoft.AspNetCore.Mvc;
using MoskPharmacy.ViewModels;
using Newtonsoft.Json.Linq;

namespace MoskPharmacy.Controllers;
public class GeoJsonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Upload()
    {
        try
        {
            var file = Request.Form.Files[0]; // İlk dosyayı al

            if (file.Length > 0)
            {
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    var content = await reader.ReadToEndAsync();
                    return Ok(content);
                }
            }
            else
            {
                return BadRequest("Yüklenen dosya boş.");
            }
        }
        catch (System.Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex}");
        };
    }
}
