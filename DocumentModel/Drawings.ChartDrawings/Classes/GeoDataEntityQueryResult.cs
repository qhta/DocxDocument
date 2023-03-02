namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataEntityQueryResult Class.
/// </summary>
public record GeoDataEntityQueryResult
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