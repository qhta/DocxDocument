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
    get => (Boolean?)OpenXmlElement?.Fronzen?.Value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
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
    get => (Boolean?)OpenXmlElement?.Frozen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Frozen = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  public WebExtensionStoreReference? WebExtensionStoreReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  public WebExtensionReferenceList? WebExtensionReferenceList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  public WebExtensionPropertyBag? WebExtensionPropertyBag
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  public WebExtensionBindingList? WebExtensionBindingList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  public Snapshot? Snapshot
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
