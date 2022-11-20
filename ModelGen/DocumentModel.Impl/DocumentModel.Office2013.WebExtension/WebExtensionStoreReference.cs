namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionStoreReference Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtension.IOfficeArtExtensionList))]
public class WebExtensionStoreReference: IWebExtensionStoreReference
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
  /// version, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Version
  {
    get;
    set;
  }
  
  /// <summary>
  /// store, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Store
  {
    get;
    set;
  }
  
  /// <summary>
  /// storeType, this property is only available in Office 2013 and later.
  /// </summary>
  public string? StoreType
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
