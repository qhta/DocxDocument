namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public interface GeoChildEntitiesQueryResult
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery? GeoChildEntitiesQuery { get ; set; }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoChildEntities? GeoChildEntities { get ; set; }
  
}
