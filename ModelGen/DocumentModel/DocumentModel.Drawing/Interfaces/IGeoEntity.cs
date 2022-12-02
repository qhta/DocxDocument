namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoEntity Class.
/// </summary>
public interface IGeoEntity // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName { get ; set; }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get ; set; }
  
}
