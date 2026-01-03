namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoPolygons Class.
/// </summary>
public interface GeoPolygons: IModelElement
{
  public Collection<GeoPolygon>? Items { get; set; }
}