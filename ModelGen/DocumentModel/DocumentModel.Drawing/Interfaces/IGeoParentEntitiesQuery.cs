namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoParentEntitiesQuery Class.
/// </summary>
public interface IGeoParentEntitiesQuery // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? EntityId { get ; set; }
  
}
