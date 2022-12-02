namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public interface IGeoChildEntitiesQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  public DocumentModel.Drawing.IGeoChildEntitiesQuery? GeoChildEntitiesQuery { get ; set; }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  public DocumentModel.Drawing.IGeoChildEntities? GeoChildEntities { get ; set; }
  
}
