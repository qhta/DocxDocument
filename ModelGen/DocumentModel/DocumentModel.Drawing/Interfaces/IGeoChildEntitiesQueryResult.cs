namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public interface IGeoChildEntitiesQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  public IGeoChildEntitiesQuery? GeoChildEntitiesQuery { get ; set; }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  public IGeoChildEntities? GeoChildEntities { get ; set; }
  
}
