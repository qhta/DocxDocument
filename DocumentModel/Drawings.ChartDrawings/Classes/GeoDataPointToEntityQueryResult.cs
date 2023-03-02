namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public record GeoDataPointToEntityQueryResult
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