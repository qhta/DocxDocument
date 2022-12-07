namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoHierarchyEntity Class.
/// </summary>
public interface GeoHierarchyEntity
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get ; set; }
  
}
