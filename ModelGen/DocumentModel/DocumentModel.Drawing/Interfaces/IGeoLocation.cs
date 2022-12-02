namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
public interface IGeoLocation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Latitude { get ; set; }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Longitude { get ; set; }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName { get ; set; }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get ; set; }
  
  /// <summary>
  /// Address.
  /// </summary>
  public IAddress? Address { get ; set; }
  
}
