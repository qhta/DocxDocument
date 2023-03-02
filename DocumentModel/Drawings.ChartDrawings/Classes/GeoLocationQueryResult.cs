namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocationQueryResult Class.
/// </summary>
public record GeoLocationQueryResult
{
  /// <summary>
  ///   GeoLocationQuery.
  /// </summary>
  public GeoLocationQuery? GeoLocationQuery { get; set; }

  /// <summary>
  ///   GeoLocations.
  /// </summary>
  public GeoLocations? GeoLocations { get; set; }
}