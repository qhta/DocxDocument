namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionBindingList Class.
/// </summary>
public class WebExtensionBindingListImpl: ModelElementImpl, WebExtensionBindingList
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExtensionBindingListImpl(): base() {}
  
  public WebExtensionBindingListImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<WebExtensionBinding>? WebExtensionBindings
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
