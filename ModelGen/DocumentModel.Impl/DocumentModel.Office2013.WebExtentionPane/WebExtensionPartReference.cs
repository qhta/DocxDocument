namespace DocumentModel.Office2013.WebExtentionPane;

/// <summary>
/// Defines the WebExtensionPartReference Class.
/// </summary>
public class WebExtensionPartReference: IWebExtensionPartReference
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
