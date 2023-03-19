namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoHierarchyEntity Class.
/// </summary>
public class GeoHierarchyEntity: ModelElement
{
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName { get; set; }

  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get; set; }

  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get; set; }
}