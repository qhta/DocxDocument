namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public class GeoLocationQueryResultImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>, GeoLocationQueryResult
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public GeoLocationQuery? GeoLocationQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public GeoLocations? GeoLocations
  {
    get;
    set;
  }
  
}
