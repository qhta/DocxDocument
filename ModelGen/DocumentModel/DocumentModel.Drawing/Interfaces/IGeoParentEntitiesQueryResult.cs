namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public interface IGeoParentEntitiesQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public DocumentModel.Drawing.IGeoParentEntitiesQuery? GeoParentEntitiesQuery { get ; set; }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public DocumentModel.Drawing.IGeoEntity? GeoEntity { get ; set; }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public DocumentModel.Drawing.IGeoParentEntity? GeoParentEntity { get ; set; }
  
}
