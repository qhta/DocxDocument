namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionReference Class.
/// </summary>
public interface IWebExtensionReference // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
}
