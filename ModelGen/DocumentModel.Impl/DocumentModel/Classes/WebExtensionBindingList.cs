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
  
  public Collection<WebExtensionBinding>? WebExtensionBindings
  {
    get;
    set;
  }
  
}
