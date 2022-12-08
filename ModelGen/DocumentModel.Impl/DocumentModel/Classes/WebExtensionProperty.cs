namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionProperty Class.
/// </summary>
public class WebExtensionPropertyImpl: ModelElementImpl, WebExtensionProperty
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// value, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Value
  {
    get;
    set;
  }
  
}
