namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualGroupProperties Class.
/// </summary>
public interface INonVisualGroupProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsLegacyGroup { get ; set; }
  
}
