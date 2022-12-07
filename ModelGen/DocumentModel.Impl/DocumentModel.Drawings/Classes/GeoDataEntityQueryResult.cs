namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public class GeoDataEntityQueryResultImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult>, GeoDataEntityQueryResult
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public GeoDataEntityQuery? GeoDataEntityQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public GeoData? GeoData
  {
    get;
    set;
  }
  
}
