namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
