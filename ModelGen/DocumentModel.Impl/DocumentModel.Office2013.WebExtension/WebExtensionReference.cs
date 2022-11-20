namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionReference Class.
/// </summary>
public class WebExtensionReference: IWebExtensionReference
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
