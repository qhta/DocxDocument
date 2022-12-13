namespace DocumentModel;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public class WebExtensionImpl: ModelElementImpl, WebExtension
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExtensionImpl(): base() {}
  
  public WebExtensionImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public Boolean? Fronzen
  {
    get => (System.Boolean?)OpenXmlElement?.Fronzen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Fronzen = (System.Boolean?)value;
    }
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
  /// frozen, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Frozen
  {
    get => (System.Boolean?)OpenXmlElement?.Frozen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Frozen = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  public DocumentModel.WebExtensionStoreReference? WebExtensionStoreReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  public DocumentModel.WebExtensionReferenceList? WebExtensionReferenceList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  public DocumentModel.WebExtensionPropertyBag? WebExtensionPropertyBag
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  public DocumentModel.WebExtensionBindingList? WebExtensionBindingList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  public DocumentModel.Snapshot? Snapshot
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
