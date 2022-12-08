namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionStoreReference Class.
/// </summary>
public class WebExtensionStoreReferenceImpl: ModelElementImpl, WebExtensionStoreReference
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// version, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Version
  {
    get;
    set;
  }
  
  /// <summary>
  /// store, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Store
  {
    get;
    set;
  }
  
  /// <summary>
  /// storeType, this property is only available in Office 2013 and later.
  /// </summary>
  public String? StoreType
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
