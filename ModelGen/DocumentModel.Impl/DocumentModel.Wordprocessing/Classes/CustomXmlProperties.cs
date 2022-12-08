namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Element Properties.
/// </summary>
public class CustomXmlPropertiesImpl: ModelElementImpl, CustomXmlProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Custom XML Element Placeholder Text.
  /// </summary>
  public String? CustomXmlPlaceholder
  {
    get;
    set;
  }
  
  public Collection<CustomXmlAttribute>? CustomXmlAttributes
  {
    get;
    set;
  }
  
}
