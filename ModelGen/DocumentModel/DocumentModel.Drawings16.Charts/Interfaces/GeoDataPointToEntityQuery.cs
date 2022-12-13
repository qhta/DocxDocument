namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public interface GeoDataPointToEntityQuery
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.EntityTypeEnum? EntityType { get ; set; }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get ; set; }
  
}
