namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionBinding Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtension.IOfficeArtExtensionList))]
public class WebExtensionBinding: IWebExtensionBinding
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// appref, this property is only available in Office 2013 and later.
  /// </summary>
  public string? AppReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2013.WebExtension.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
