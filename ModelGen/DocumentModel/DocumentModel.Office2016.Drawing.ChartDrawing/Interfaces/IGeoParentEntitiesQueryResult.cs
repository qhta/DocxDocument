namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoEntity))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoParentEntitiesQuery))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoParentEntity))]
public interface IGeoParentEntitiesQueryResult // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
