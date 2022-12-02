namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public interface IGeoDataPointToEntityQuery // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get ; set; }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get ; set; }
  
}
