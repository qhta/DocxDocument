namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataEntityQueryResult Class.
/// </summary>
public class GeoDataEntityQueryResult: ModelElement
{
  /// <summary>
  ///   GeoDataEntityQuery.
  /// </summary>
  public GeoDataEntityQuery? GeoDataEntityQuery { get; set; }

  /// <summary>
  ///   GeoData.
  /// </summary>
  public GeoData? GeoData { get; set; }
}