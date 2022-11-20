namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataPointQuery))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataPointToEntityQuery))]
public class GeoDataPointToEntityQueryResult: IGeoDataPointToEntityQueryResult
{
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public IGeoDataPointQuery? GeoDataPointQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public IGeoDataPointToEntityQuery? GeoDataPointToEntityQuery
  {
    get;
    set;
  }
  
}
