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
    get;
    set;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// appref, this property is only available in Office 2013 and later.
  /// </summary>
  public String? AppReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
