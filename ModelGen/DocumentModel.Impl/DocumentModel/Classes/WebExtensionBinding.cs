namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionBinding Class.
/// </summary>
public class WebExtensionBindingImpl: ModelElementImpl, WebExtensionBinding
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Type
  {
    get => (String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// appref, this property is only available in Office 2013 and later.
  /// </summary>
  public String? AppReference
  {
    get => (String?)OpenXmlElement?.AppReference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AppReference = (System.String?)value;
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
