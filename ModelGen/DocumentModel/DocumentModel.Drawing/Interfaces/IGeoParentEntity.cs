namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public interface IGeoParentEntity // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? EntityId { get ; set; }
  
}
