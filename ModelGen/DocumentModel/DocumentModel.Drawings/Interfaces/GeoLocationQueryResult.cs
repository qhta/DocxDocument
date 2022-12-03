namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public interface GeoLocationQueryResult // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public GeoLocationQuery? GeoLocationQuery { get ; set; }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public GeoLocations? GeoLocations { get ; set; }
  
}
