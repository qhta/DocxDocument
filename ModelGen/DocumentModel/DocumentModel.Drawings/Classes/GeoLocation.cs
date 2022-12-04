namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
public class GeoLocation
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Address.
  /// </summary>
  public Address? Address
  {
    get;
    set;
  }
  
}
