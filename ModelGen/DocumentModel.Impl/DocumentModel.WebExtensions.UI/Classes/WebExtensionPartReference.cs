namespace DocumentModel.WebExtensions.UI;

/// <summary>
/// Defines the WebExtensionPartReference Class.
/// </summary>
public partial class WebExtensionPartReferenceImpl: ModelElementImpl, WebExtensionPartReference
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WebExtensionPartReferenceImpl(): base() {}
  
  public WebExtensionPartReferenceImpl(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference openXmlElement): base(openXmlElement)
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
  
}
