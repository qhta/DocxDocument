namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public class GeoDataPointToEntityQueryResult: ModelElement
{
  /// <summary>
  ///   GeoDataPointQuery.
  /// </summary>
  public GeoDataPointQuery? GeoDataPointQuery { get; set; }

  /// <summary>
  ///   GeoDataPointToEntityQuery.
  /// </summary>
  public GeoDataPointToEntityQuery? GeoDataPointToEntityQuery { get; set; }
}