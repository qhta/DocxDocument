namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoPolygons Class.
/// </summary>
public record GeoPolygons
{
  public Collection<GeoPolygon>? Items { get; set; }
}