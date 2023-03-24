namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoPolygons Class.
/// </summary>
public class GeoPolygons: ModelElement
{
  public Collection<GeoPolygon>? Items { get; set; }
}