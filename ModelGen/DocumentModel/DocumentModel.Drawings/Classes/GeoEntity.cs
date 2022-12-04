namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoEntity Class.
/// </summary>
public class GeoEntity
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType
  {
    get;
    set;
  }
  
}
