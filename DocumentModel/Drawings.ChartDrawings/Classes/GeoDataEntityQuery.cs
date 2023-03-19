namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataEntityQuery Class.
/// </summary>
public class GeoDataEntityQuery: ModelElement
{
  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get; set; }

  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get; set; }
}