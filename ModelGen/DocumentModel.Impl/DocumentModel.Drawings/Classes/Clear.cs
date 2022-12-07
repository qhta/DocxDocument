namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public class ClearImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear>, Clear
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public GeoLocationQueryResults? GeoLocationQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public GeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get;
    set;
  }
  
}
