namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public interface IGeoLocationQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public DocumentModel.Drawing.IGeoLocationQuery? GeoLocationQuery { get ; set; }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public DocumentModel.Drawing.IGeoLocations? GeoLocations { get ; set; }
  
}
