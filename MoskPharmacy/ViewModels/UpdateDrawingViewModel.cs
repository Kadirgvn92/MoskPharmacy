using NetTopologySuite.Geometries;

namespace MoskPharmacy.ViewModels;

public class UpdateDrawingViewModel
{
    public int DrawingId { get; set; }
    public string Type { get; set; }
    public Geometry Geometry { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
}
