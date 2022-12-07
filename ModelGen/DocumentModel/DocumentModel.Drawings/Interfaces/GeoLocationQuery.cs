namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoLocationQuery Class.
/// </summary>
public interface GeoLocationQuery
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get ; set; }
  
}
