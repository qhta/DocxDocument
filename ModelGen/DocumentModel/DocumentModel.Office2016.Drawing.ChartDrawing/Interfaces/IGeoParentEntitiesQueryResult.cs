namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public interface IGeoParentEntitiesQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoParentEntitiesQuery? GeoParentEntitiesQuery { get ; set; }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoEntity? GeoEntity { get ; set; }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoParentEntity? GeoParentEntity { get ; set; }
  
}
