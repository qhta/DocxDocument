namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoEntity Class.
/// </summary>
public interface GeoEntity
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName { get ; set; }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.EntityTypeEnum? EntityType { get ; set; }
  
}
