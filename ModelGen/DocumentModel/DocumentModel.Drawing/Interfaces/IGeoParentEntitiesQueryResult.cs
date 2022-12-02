namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public interface IGeoParentEntitiesQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public IGeoParentEntitiesQuery? GeoParentEntitiesQuery { get ; set; }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public IGeoEntity? GeoEntity { get ; set; }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public IGeoParentEntity? GeoParentEntity { get ; set; }
  
}
