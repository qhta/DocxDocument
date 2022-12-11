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
  
  public WebExtensionStoreReferenceImpl(): base() {}
  
  public WebExtensionStoreReferenceImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// version, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Version
  {
    get => (String?)OpenXmlElement?.Version?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Version = (System.String?)value;
    }
  }
  
  /// <summary>
  /// store, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Store
  {
    get => (String?)OpenXmlElement?.Store?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Store = (System.String?)value;
    }
  }
  
  /// <summary>
  /// storeType, this property is only available in Office 2013 and later.
  /// </summary>
  public String? StoreType
  {
    get => (String?)OpenXmlElement?.StoreType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StoreType = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
