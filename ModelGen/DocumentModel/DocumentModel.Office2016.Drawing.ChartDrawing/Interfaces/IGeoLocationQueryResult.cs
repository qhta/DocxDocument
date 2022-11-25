namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public interface IGeoLocationQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoLocationQuery? GeoLocationQuery { get ; set; }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoLocations? GeoLocations { get ; set; }
  
}
