namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public interface GeoLocationQueryResult
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoLocationQuery? GeoLocationQuery { get ; set; }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoLocations? GeoLocations { get ; set; }
  
}
