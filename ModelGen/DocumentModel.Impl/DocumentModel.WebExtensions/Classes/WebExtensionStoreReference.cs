namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtensionStoreReference Class.
/// </summary>
public partial class WebExtensionStoreReferenceImpl: ModelElementImpl, WebExtensionStoreReference
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
    get => (System.String?)OpenXmlElement?.Id?.Value;
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
    get => (System.String?)OpenXmlElement?.Version?.Value;
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
    get => (System.String?)OpenXmlElement?.Store?.Value;
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
    get => (System.String?)OpenXmlElement?.StoreType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StoreType = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.WebExtensions.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.WebExtensions.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.WebExtensions.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
