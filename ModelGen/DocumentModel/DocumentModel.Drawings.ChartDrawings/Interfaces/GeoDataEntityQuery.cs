namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQuery Class.
/// </summary>
public partial interface GeoDataEntityQuery
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? EntityType { get; set; }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get; set; }
  
}
