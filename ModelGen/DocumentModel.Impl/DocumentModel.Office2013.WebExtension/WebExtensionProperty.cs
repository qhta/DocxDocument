namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionProperty Class.
/// </summary>
public class WebExtensionProperty: IWebExtensionProperty
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// value, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Value
  {
    get;
    set;
  }
  
}
