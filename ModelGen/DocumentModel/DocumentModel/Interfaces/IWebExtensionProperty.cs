namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionProperty Class.
/// </summary>
public interface IWebExtensionProperty // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// value, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Value { get ; set; }
  
}
