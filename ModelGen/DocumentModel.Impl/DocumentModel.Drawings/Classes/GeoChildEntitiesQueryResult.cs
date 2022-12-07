namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public class GeoChildEntitiesQueryResultImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult>, GeoChildEntitiesQueryResult
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  public GeoChildEntitiesQuery? GeoChildEntitiesQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  public GeoChildEntities? GeoChildEntities
  {
    get;
    set;
  }
  
}
