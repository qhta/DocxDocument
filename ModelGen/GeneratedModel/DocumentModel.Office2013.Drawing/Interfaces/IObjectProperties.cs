namespace DocumentModel.Office2013.Drawing;

/// <summary>
/// Defines the ObjectProperties Class.
/// </summary>
public interface IObjectProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// objectId, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? IsActiveX { get ; set; }
  
  /// <summary>
  /// linkType, this property is only available in Office 2013 and later.
  /// </summary>
  public string? LinkType { get ; set; }
  
}
