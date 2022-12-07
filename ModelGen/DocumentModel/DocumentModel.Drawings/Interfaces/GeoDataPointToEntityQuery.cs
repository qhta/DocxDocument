namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public interface GeoDataPointToEntityQuery
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get ; set; }
  
}
