namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public partial interface GeoParentEntitiesQueryResult
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQuery? GeoParentEntitiesQuery { get; set; }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoEntity? GeoEntity { get; set; }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoParentEntity? GeoParentEntity { get; set; }
  
}
