namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoHierarchyEntity Class.
/// </summary>
public interface IGeoHierarchyEntity // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? EntityName { get ; set; }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? EntityId { get ; set; }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.EntityTypeEnum? EntityType { get ; set; }
  
}
