namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoParentEntitiesQuery Class.
/// </summary>
public record GeoParentEntitiesQuery
{
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get; set; }
}