namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public interface GeoLocationQueryResult
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoLocationQuery? GeoLocationQuery { get ; set; }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoLocations? GeoLocations { get ; set; }
  
}
