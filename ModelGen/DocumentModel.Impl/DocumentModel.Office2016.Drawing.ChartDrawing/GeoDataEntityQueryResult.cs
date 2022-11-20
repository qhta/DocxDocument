namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoData))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataEntityQuery))]
public class GeoDataEntityQueryResult: IGeoDataEntityQueryResult
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public IGeoDataEntityQuery? GeoDataEntityQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public IGeoData? GeoData
  {
    get;
    set;
  }
  
}
