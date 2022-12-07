namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public class GeoParentEntitiesQueryResultImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult>, GeoParentEntitiesQueryResult
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public GeoParentEntitiesQuery? GeoParentEntitiesQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public GeoEntity? GeoEntity
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public GeoParentEntity? GeoParentEntity
  {
    get;
    set;
  }
  
}
