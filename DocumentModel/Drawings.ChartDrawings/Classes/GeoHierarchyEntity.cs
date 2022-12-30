namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoHierarchyEntity Class.
/// </summary>
public partial class GeoHierarchyEntity
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName { get; set; }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get; set; }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? EntityType { get; set; }
  
}
