namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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