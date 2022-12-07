namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public class GeoDataPointToEntityQueryResultImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult>, GeoDataPointToEntityQueryResult
{
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public GeoDataPointQuery? GeoDataPointQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public GeoDataPointToEntityQuery? GeoDataPointToEntityQuery
  {
    get;
    set;
  }
  
}
