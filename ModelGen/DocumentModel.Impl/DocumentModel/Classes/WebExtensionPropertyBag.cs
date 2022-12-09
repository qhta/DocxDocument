namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public class WebExtensionPropertyBagImpl: ModelElementImpl, WebExtensionPropertyBag
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<WebExtensionProperty>? WebExtensionProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
