namespace DocumentModel.Office2013.Drawing;

/// <summary>
/// Defines the ObjectProperties Class.
/// </summary>
public interface IObjectProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// objectId, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? IsActiveX { get ; set; }
  
  /// <summary>
  /// linkType, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? LinkType { get ; set; }
  
}
