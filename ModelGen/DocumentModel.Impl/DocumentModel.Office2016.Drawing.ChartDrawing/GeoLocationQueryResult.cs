namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoLocationQuery))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoLocations))]
public class GeoLocationQueryResult: IGeoLocationQueryResult
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public IGeoLocationQuery? GeoLocationQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public IGeoLocations? GeoLocations
  {
    get;
    set;
  }
  
}
