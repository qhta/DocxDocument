namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocationQueryResult Class.
/// </summary>
public interface GeoLocationQueryResult: IModelElement
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