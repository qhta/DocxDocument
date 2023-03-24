namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public class GeoDataPointToEntityQuery: ModelElement
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