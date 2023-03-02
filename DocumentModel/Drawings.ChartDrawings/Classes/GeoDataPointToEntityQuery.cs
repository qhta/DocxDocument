namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public record GeoDataPointToEntityQuery
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