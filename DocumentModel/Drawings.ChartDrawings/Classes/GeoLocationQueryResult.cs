namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocationQueryResult Class.
/// </summary>
public class GeoLocationQueryResult: ModelElement
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