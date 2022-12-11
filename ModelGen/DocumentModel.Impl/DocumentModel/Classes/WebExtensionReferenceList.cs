namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public class WebExtensionReferenceListImpl: ModelElementImpl, WebExtensionReferenceList
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExtensionReferenceListImpl(): base() {}
  
  public WebExtensionReferenceListImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<WebExtensionStoreReference>? WebExtensionStoreReferences
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
