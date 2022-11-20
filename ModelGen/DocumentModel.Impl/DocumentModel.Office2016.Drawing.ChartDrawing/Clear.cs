namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Clear Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoChildEntitiesQueryResults))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataEntityQueryResults))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoDataPointToEntityQueryResults))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoLocationQueryResults))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoParentEntitiesQueryResults))]
public class Clear: IClear
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public IGeoLocationQueryResults? GeoLocationQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public IGeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public IGeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public IGeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public IGeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get;
    set;
  }
  
}
