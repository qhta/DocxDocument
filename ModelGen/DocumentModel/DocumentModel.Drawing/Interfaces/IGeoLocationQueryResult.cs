namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public interface IGeoLocationQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public IGeoLocationQuery? GeoLocationQuery { get ; set; }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public IGeoLocations? GeoLocations { get ; set; }
  
}
