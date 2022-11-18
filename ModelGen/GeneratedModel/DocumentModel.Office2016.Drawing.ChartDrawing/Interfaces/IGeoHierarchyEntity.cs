namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoHierarchyEntity Class.
/// </summary>
public interface IGeoHierarchyEntity // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityName { get ; set; }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityId { get ; set; }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get ; set; }
  
}
